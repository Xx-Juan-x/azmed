using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            //.Where(r => r.CANTIDAD != 0 && r.PRECIO != 0)
            //.Where(r => r.PEDIDO != null)
            // Traigo la cantidad de especialidades que tengo    
            string[] SERIES_ARRAY_COMPRAS = cORDEN_COMPRA.OBTENER_ORDENES_COMPRAS().AsEnumerable().Select(r => r.PEDIDO.DESCRIPCION).Distinct().ToArray();
            var LISTA_COMPRAS = (from loc in cLISTA_ORDEN_COMPRAS.OBTENER_LISTA_COMPRAS()  select new {precio = loc.PRECIO,orden = loc.COMPRA.ID_ORDEN_COMPRA}).ToList();
            //string[] SERIES_PRECIOS = LISTA_COMPRAS.Sum(w => w.precio)
            int[] SERIES_PRECIOS = LISTA_COMPRAS.GroupBy(a => a.orden).Select(i =>  i.Sum(x => (int)x.precio)).ToArray();
            // For que me permite cargar los datos en el chart
            chart_CANTIDAD_GASTOS.Series[0].Points.DataBindXY(SERIES_ARRAY_COMPRAS, SERIES_PRECIOS);

            for (int i = 0; i < SERIES_ARRAY_COMPRAS.Length; i++)
            {
                //Titulo de la serie
                Series SERIES = chart_CANTIDAD_GASTOS.Series.Add(SERIES_ARRAY_COMPRAS[i]);

                // Agrego la cantidad de Profesionales (las barras)
            }
        }

        private void btnCERRAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
