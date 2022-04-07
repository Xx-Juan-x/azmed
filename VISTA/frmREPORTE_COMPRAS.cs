using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmREPORTE_COMPRAS : Form
    {
        private static frmREPORTE_COMPRAS instancia;

        public static frmREPORTE_COMPRAS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmREPORTE_COMPRAS();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmREPORTE_COMPRAS();
            }
            return instancia;
        }

        private CONTROLADORA.ORDENES_DE_COMPRAS cORDEN_COMPRA;
        private CONTROLADORA.LISTA_ORDENES_DE_COMPRAS cLISTA_ORDEN_COMPRAS;

        public frmREPORTE_COMPRAS()
        {
            InitializeComponent();
            cORDEN_COMPRA = CONTROLADORA.ORDENES_DE_COMPRAS.OBTENER_INSTANCIA();
            cLISTA_ORDEN_COMPRAS = CONTROLADORA.LISTA_ORDENES_DE_COMPRAS.OBTENER_INSTANCIA();
            ARMAR_CHART_COMPRAS();
        }

        private void ARMAR_CHART_COMPRAS()
        {
            DateTime DIA_ACTUAL = DateTime.Now;
            DateTime DIA_ATRASADO = DIA_ACTUAL.AddDays(-30);

            var ORDENES = (from a in cORDEN_COMPRA.OBTENER_ORDENES_COMPRAS()
                           where a.FECHA >= DIA_ATRASADO && a.FECHA <= DIA_ACTUAL
                           select a).ToList();

            decimal GASTOS = 0;

            foreach (var COMPRAS in ORDENES)
            {
                var LISTA_ORDENES = (from a in cLISTA_ORDEN_COMPRAS.OBTENER_LISTA_COMPRAS()
                               where a.COMPRA.ID_ORDEN_COMPRA == COMPRAS.ID_ORDEN_COMPRA
                               select a).ToList();

                foreach (var ITEMS_COMPRAS in LISTA_ORDENES)
                {
                    GASTOS += ITEMS_COMPRAS.PRECIO * ITEMS_COMPRAS.CANTIDAD;
                }
            }
            MessageBox.Show(GASTOS.ToString());
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
