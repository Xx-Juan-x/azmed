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
            ARMA_CHART();
        }

        DateTime DIA_ACTUAL = DateTime.Now.AddDays(-28);

        private void ARMA_CHART()
        {
            
            // Le coloco un nombre al gráfico
            chart_CANTIDAD_TURNOS.Titles.Add("CANTIDAD DE TURNOS SEMANALES");

            //Doy un rango de 28 días atrasados, para ver la cantidad de turnos
            DateTime[] SERIE1 = new DateTime[2];
            DateTime[] SERIE2 = new DateTime[2];
            DateTime[] SERIE3 = new DateTime[2];
            DateTime[] SERIE4 = new DateTime[2];

            SERIE1[0] = DIA_ACTUAL;//16/02/2022
            SERIE1[1] = DIA_ACTUAL.AddDays(6);//22/02/2022

            SERIE2[0] = SERIE1[1].AddDays(1);//23/02/2022
            SERIE2[1] = SERIE2[0].AddDays(6);//29/02/2022

            SERIE3[0] = SERIE2[0].AddDays(1);//30/02/2022
            SERIE3[1] = SERIE3[0].AddDays(6);//06/03/2022

            SERIE4[0] = SERIE3[0].AddDays(1);//07/03/2022
            SERIE4[1] = SERIE4[0].AddDays(6);//13/03/2022

            Series FECHA1 = chart_CANTIDAD_TURNOS.Series.Add(SERIE1[0].ToShortDateString() + " A " + SERIE1[1].ToShortDateString());
            Series FECHA2 = chart_CANTIDAD_TURNOS.Series.Add(SERIE2[0].ToShortDateString() + " A " + SERIE2[1].ToShortDateString());
            Series FECHA3 = chart_CANTIDAD_TURNOS.Series.Add(SERIE3[0].ToShortDateString() + " A " + SERIE3[1].ToShortDateString());
            Series FECHA4 = chart_CANTIDAD_TURNOS.Series.Add(SERIE4[0].ToShortDateString() + " A " + SERIE4[1].ToShortDateString());

            

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

            

            chart_CANTIDAD_TURNOS.Series[0].ChartType = SeriesChartType.Line;
            chart_CANTIDAD_TURNOS.Series[1].ChartType = SeriesChartType.Line;
            chart_CANTIDAD_TURNOS.Series[2].ChartType = SeriesChartType.Line;
            chart_CANTIDAD_TURNOS.Series[3].ChartType = SeriesChartType.Line;

            FECHA1.Points.Add(TURNOS1);
            FECHA2.Points.Add(TURNOS2);
            FECHA3.Points.Add(TURNOS3);
            FECHA4.Points.Add(TURNOS4);

            SeriesChartType TIPO_GRAFICO = SeriesChartType.Line;

            //FECHA1.Points.Add(1, new );

        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
