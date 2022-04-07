﻿using System;
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
    public partial class frmREPORTE_ESTADISTICO : Form
    {
        private static frmREPORTE_ESTADISTICO instancia;

        public static frmREPORTE_ESTADISTICO OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmREPORTE_ESTADISTICO();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmREPORTE_ESTADISTICO();
            }
            return instancia;
        }

        CONTROLADORA.ESPECIALIDADES cESPECIALIDADES;
        CONTROLADORA.USUARIOS cPROFESIONALES;       
        
        public frmREPORTE_ESTADISTICO()
        {
            InitializeComponent();
            cESPECIALIDADES = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();
            cPROFESIONALES = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            ARMAR_CHART();
        }

        private void ARMAR_CHART()
        {          
            // Traigo la cantidad de especialidades que tengo    
            string[] SERIES_ARRAY_ESPECIALIDAD = cESPECIALIDADES.OBTENER_ESPECIALIDADES().AsEnumerable().Where(r => r.NOMBRE != null).Select(r => r.NOMBRE).Distinct().ToArray();
            string[] LISTA_PROFESIONALES = cPROFESIONALES.OBTENER_PROFESIONALES().AsEnumerable().Where(r => r.ESPECIALIDADES != null).Select(r => r.ESPECIALIDADES.NOMBRE).ToArray();

            // For que me permite cargar los datos en el chart
            for (int i = 0; i < SERIES_ARRAY_ESPECIALIDAD.Length; i++)
            {
                //Titulo de la serie
                Series SERIES = chartESPECIALIDAD_PROFESIONAL.Series.Add(SERIES_ARRAY_ESPECIALIDAD[i]);
                

                // Asocio las series con la cantidad de profesionales
                int CANTIDAD_PROFESIONALES = (from row in LISTA_PROFESIONALES
                                              where row == SERIES_ARRAY_ESPECIALIDAD[i]
                                              select row).Count();

                // Agrego la cantidad de Profesionales (las barras)
                SERIES.Points.Add(CANTIDAD_PROFESIONALES);
                //chartESPECIALIDAD_PROFESIONAL.AlignDataPointsByAxisLabel(SERIES_ARRAY_ESPECIALIDAD[i]);

                //SERIES.Points.Add(Convert.ToDouble(SERIES_ARRAY_ESPECIALIDAD[i]));

                //chartESPECIALIDAD_PROFESIONAL.Series[SERIES_ARRAY_ESPECIALIDAD[i]]["PointWidth"] = "0.8";
            }
        }
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
