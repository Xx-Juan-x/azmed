using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmPROFESIONALES : Form
    {
        //PATRON SINGLETON
        private static frmPROFESIONALES instancia;

        public static frmPROFESIONALES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmPROFESIONALES();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmPROFESIONALES();
            }
            return instancia;
        }

        private CONTROLADORA.PROFESIONALES cPROFESIONALES;
        private MODELO.PROFESIONAL oPROFESIONAL;
        private CONTROLADORA.ESPECIALIDADES cESPECIALIDADES;
        string ACCION;

        public frmPROFESIONALES()
        {
            InitializeComponent();
            cPROFESIONALES = CONTROLADORA.PROFESIONALES.OBTENER_INSTANCIA();
            cESPECIALIDADES = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();

            
            ARMA_GRILLA("A");
            MODO_GRILLA();
        }

        private void ARMA_GRILLA(string TIPO)
        {
            if (TIPO == "A")
            {
                dgvLISTA_PROFESIONALES.DataSource = null;
                dgvLISTA_PROFESIONALES.DataSource = cPROFESIONALES.OBTENER_PROFESIONALES();
                cmbFILTRO_ESPECIALIDAD.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();
            }
            if (TIPO == "B")
            {
                string FILTRO_PROFESIONAL = cmbFILTRO_ESPECIALIDAD.Text;
                cmbFILTRO_ESPECIALIDAD.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();

                if (FILTRO_PROFESIONAL == "TODOS")
                {
                    dgvLISTA_PROFESIONALES.DataSource = null;
                    dgvLISTA_PROFESIONALES.DataSource = cPROFESIONALES.OBTENER_PROFESIONALES();

                }
                else
                {
                    var FILTRO_ESPECIALIDAD_PROFESIONAL = (from a in cPROFESIONALES.OBTENER_PROFESIONALES()
                                                       where a.ESPECIALIDAD.NOMBRE == FILTRO_PROFESIONAL
                                                       select a).ToList();

                    dgvLISTA_PROFESIONALES.DataSource = null;
                    dgvLISTA_PROFESIONALES.DataSource = FILTRO_ESPECIALIDAD_PROFESIONAL;

                }
            }
        }
        private void MODO_GRILLA()
        {
            gbLISTA_PROFESIONALES.Enabled = true;
            gbDATOS_PROFESIONAL.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_PROFESIONALES.Enabled = false;
            gbDATOS_PROFESIONAL.Enabled = true;

            if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            }
            else
            {
                btnGUARDAR.Enabled = true;
            }
        }

        private Boolean EMAIL_BIEN_ESCRITO(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
