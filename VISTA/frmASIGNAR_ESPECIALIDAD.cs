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
    public partial class frmASIGNAR_ESPECIALIDAD : Form
    {
        private static frmASIGNAR_ESPECIALIDAD instancia;

        public static frmASIGNAR_ESPECIALIDAD OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmASIGNAR_ESPECIALIDAD();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmASIGNAR_ESPECIALIDAD();
            }
            return instancia;
        }

        private MODELO.PROFESIONAL oPROFESIONAL;
        private CONTROLADORA.PROFESIONALES cPROFESIONALES;
        private CONTROLADORA.ESPECIALIDADES cESPECIALIDADES;

        public frmASIGNAR_ESPECIALIDAD()
        {
            InitializeComponent();
            cPROFESIONALES = CONTROLADORA.PROFESIONALES.OBTENER_INSTANCIA();
            cESPECIALIDADES = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();
            ARMA_GRILLA();
            MODO_GRILLA();      
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_PROFESIONALES.DataSource = null;
            dgvLISTA_PROFESIONALES.DataSource = cPROFESIONALES.OBTENER_PROFESIONALES();
            /*dgvLISTA_PROFESIONALES.AutoGenerateColumns = false;

            if (dgvLISTA_PROFESIONALES.Columns.Contains("CLAVE") && dgvLISTA_PROFESIONALES.Columns.Contains("FECHA") && dgvLISTA_PROFESIONALES.Columns.Contains("PLAN") && dgvLISTA_PROFESIONALES.Columns.Contains("OBRA_SOCIAL"))
            {
                dgvLISTA_PROFESIONALES.Columns.Remove("FECHA");
                dgvLISTA_PROFESIONALES.Columns.Remove("CLAVE");
                dgvLISTA_PROFESIONALES.Columns.Remove("PLAN");
                dgvLISTA_PROFESIONALES.Columns.Remove("OBRA_SOCIAL");
            }*/
        }

        private void MODO_GRILLA()
        {
            gbLISTA_PROFESIONALES.Enabled = true;
            gbESPECIALIDADES.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_PROFESIONALES.Enabled = false;
            gbESPECIALIDADES.Enabled = true;
        }

        private void btnASIGNAR_Click(object sender, EventArgs e)
        {
            //oPROFESIONAL = new MODELO.USUARIO();
            // LIMPIO MI COMBOBOX 
            cmbESPECIALIDADES.DataSource = null;

            //AÑADO MI PROPIEDAD ESPECIALIDAD A MI COMBOBOX
            cmbESPECIALIDADES.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();
            cmbESPECIALIDADES.DisplayMember = "TIPO_ESPECIALIDAD";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PROFESIONALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista para poder asignarle una especialidad", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPROFESIONAL = (MODELO.PROFESIONAL)dgvLISTA_PROFESIONALES.CurrentRow.DataBoundItem;

            oPROFESIONAL.ESPECIALIDAD = (MODELO.ESPECIALIDAD)cmbESPECIALIDADES.SelectedItem;

            cPROFESIONALES.MODIFICAR_PROFESIONAL(oPROFESIONAL);

            ARMA_GRILLA();
            MODO_GRILLA();
        }

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            cmbESPECIALIDADES.DataSource = null;
            MODO_GRILLA();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
