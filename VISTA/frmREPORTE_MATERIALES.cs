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
    public partial class frmREPORTE_MATERIALES : Form
    {
        private static frmREPORTE_MATERIALES instancia;

        public static frmREPORTE_MATERIALES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmREPORTE_MATERIALES();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmREPORTE_MATERIALES();
            }
            return instancia;
        }

        private CONTROLADORA.SOLICITUDES_DE_PEDIDOS cSOLICITUD_PEDIDOS;
        private CONTROLADORA.LISTA_DE_PEDIDOS cLISTA_PEDIDOS;


        public frmREPORTE_MATERIALES()
        {
            InitializeComponent();
            cSOLICITUD_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            cLISTA_PEDIDOS = CONTROLADORA.LISTA_DE_PEDIDOS.OBTENER_INSTANCIA();
            ARMA_CHART_MATERIALES();
        }

        private void ARMA_CHART_MATERIALES()
        {
            DateTime DIA_ACTUAL = DateTime.Now;
            DateTime DIA_ATRASADO = DIA_ACTUAL.AddDays(-30);

            var SOLICITUDES = (from a in cSOLICITUD_PEDIDOS.OBTENER_SOLICITUDES_PEDIDOS()
                           where a.FECHA >= DIA_ATRASADO && a.FECHA <= DIA_ACTUAL
                           select a).ToList();

            foreach (var PEDIDOS in SOLICITUDES)
            {
                var LISTA_PEDIDOS = (from a in cLISTA_PEDIDOS.OBTENER_LISTA_PEDIDOS()
                                     where a.PEDIDO.ID_SOLICITUD_PEDIDO == PEDIDOS.ID_SOLICITUD_PEDIDO
                                     select a).ToList();

                // CREAR UN ARRAY POR CADA MATERIAL, CADA UNO ES ACUMULADOR DE INT
                foreach (var ITEMS_PEDIDOS in LISTA_PEDIDOS)
                {
                    
                }
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
