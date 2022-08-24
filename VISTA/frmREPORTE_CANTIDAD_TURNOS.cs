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
    public partial class frmREPORTE_CANTIDAD_TURNOS : Form
    {
        private static frmREPORTE_CANTIDAD_TURNOS instancia;

        public static frmREPORTE_CANTIDAD_TURNOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmREPORTE_CANTIDAD_TURNOS();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmREPORTE_CANTIDAD_TURNOS();
            }
            return instancia;
        }

        CONTROLADORA.TURNOS cTURNOS;        

        public frmREPORTE_CANTIDAD_TURNOS()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();

            //Defino el tipo de gráfico
            //chart_CANTIDAD_TURNOS.Series[0].ChartType = SeriesChartType.Line;
            ARMA_CHART();
        }

        DateTime DIA_ACTUAL = DateTime.Now.AddDays(-28);

        private void ARMA_CHART()
        {

            // Le coloco un nombre al gráfico

            //Doy un rango de 28 días atrasados, para ver la cantidad de turnos
            DateTime[] SERIE1 = new DateTime[2];
            DateTime[] SERIE2 = new DateTime[2];
            DateTime[] SERIE3 = new DateTime[2];
            DateTime[] SERIE4 = new DateTime[2];

            SERIE1[0] = DIA_ACTUAL;//16/02/2022
            SERIE1[1] = DIA_ACTUAL.AddDays(6);//22/02/2022
            string serie1 = "Semana " + SERIE1[0].Day + "/" + SERIE1[0].Month;

            SERIE2[0] = SERIE1[1].AddDays(1);
            SERIE2[1] = SERIE2[0].AddDays(6);
            string serie2 = "Semana " + SERIE2[0].Day + "/" + SERIE2[0].Month;

            SERIE3[0] = SERIE2[1].AddDays(1);
            SERIE3[1] = SERIE3[0].AddDays(6);
            string serie3 = "Semana " + SERIE3[0].Day + "/" + SERIE3[0].Month;

            SERIE4[0] = SERIE3[1].AddDays(1);
            SERIE4[1] = SERIE4[0].AddDays(6);
            string serie4 = "Semana " + SERIE4[0].Day + "/" + SERIE4[0].Month;

            var TURNOS1 = (from a in cTURNOS.OBTENER_TURNOS()
                           where a.FECHA >= SERIE1[0] && a.FECHA <= SERIE1[1]
                           select a).Count();

            var TURNOS2 = (from a in cTURNOS.OBTENER_TURNOS()
                           where a.FECHA >= SERIE2[0] && a.FECHA <= SERIE2[1]
                           select a).Count();

            var TURNOS3 = (from a in cTURNOS.OBTENER_TURNOS()
                           where a.FECHA >= SERIE3[0] && a.FECHA <= SERIE3[1]
                           select a).Count();

            var TURNOS4 = (from a in cTURNOS.OBTENER_TURNOS()
                           where a.FECHA >= SERIE4[0] && a.FECHA <= SERIE4[1]
                           select a).Count();

            int[] seriesY = new int[4] {TURNOS1,TURNOS2,TURNOS3,TURNOS4};
            string[] seriesX = new string[4] {serie1,serie2,serie3,serie4 };

            chart_CANTIDAD_TURNOS.Series[0].Points.DataBindXY(seriesX, seriesY);
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
