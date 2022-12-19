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
    public partial class frmASIGNAR_PLAN_OBRA_SOCIAL : Form
    {

        private static frmASIGNAR_PLAN_OBRA_SOCIAL instancia;

        public static frmASIGNAR_PLAN_OBRA_SOCIAL OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmASIGNAR_PLAN_OBRA_SOCIAL();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmASIGNAR_PLAN_OBRA_SOCIAL();
            }
            return instancia;
        }

        private CONTROLADORA.USUARIOS cPACIENTES;
        private MODELO.USUARIO oPACIENTE;
        private CONTROLADORA.PLANES cPLANES;
        private CONTROLADORA.OBRAS_SOCIALES cOBRAS_SOCIALES;

        public frmASIGNAR_PLAN_OBRA_SOCIAL()
        {
            InitializeComponent();
            cPACIENTES = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            cPLANES = CONTROLADORA.PLANES.OBTENER_INSTANCIA();
            cOBRAS_SOCIALES = CONTROLADORA.OBRAS_SOCIALES.OBTENER_INSTANCIA();

            ARMA_COMBOBOX_OBRA_SOCIAL();
            ARMA_GRILLA();
            MODO_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_PACIENTES.DataSource = null;
            dgvLISTA_PACIENTES.DataSource = cPACIENTES.OBTENER_PACIENTES();
            dgvLISTA_PACIENTES.AutoGenerateColumns = false;

            if (dgvLISTA_PACIENTES.Columns.Contains("CLAVE") && dgvLISTA_PACIENTES.Columns.Contains("FECHA") && dgvLISTA_PACIENTES.Columns.Contains("ESPECIALIDADES"))
            {
                dgvLISTA_PACIENTES.Columns.Remove("FECHA");
                dgvLISTA_PACIENTES.Columns.Remove("CLAVE");
                dgvLISTA_PACIENTES.Columns.Remove("ESPECIALIDADES");
            }
        }

        private void MODO_GRILLA()
        {
            gbLISTA_PACIENTES.Enabled = true;
            gbDATOS_PLAN_OBRA_SOCIAL.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_PACIENTES.Enabled = false;
            gbDATOS_PLAN_OBRA_SOCIAL.Enabled = true;
        }

        private void ARMA_COMBOBOX_OBRA_SOCIAL()
        {
            cmbOBRA_SOCIAL.DataSource = null;
            cmbOBRA_SOCIAL.Items.Add("SELECCIONE...");
            cmbOBRA_SOCIAL.SelectedItem = "SELECCIONE...";
        }

        private void ARMA_COMBOBOX_PLAN(int ID_OBRA_SOCIAL)
        {
            cmbPLAN.DataSource = null;
            var LISTA_PLANES = (from c in cPLANES.OBTENER_PLANES()
                                       where c.OBRA_SOCIAL.ID_OBRA_SOCIAL == ID_OBRA_SOCIAL
                                       select c).ToList();

            cmbPLAN.DataSource = LISTA_PLANES;
            cmbPLAN.ValueMember = "ID_PLAN";
            cmbPLAN.DisplayMember = "NOMBRE";
        }


        private void btnASIGNAR_Click(object sender, EventArgs e)
        {
            cmbOBRA_SOCIAL.DataSource = null;

            //AÑADO MI PROPIEDAD OBRA SOCIAL A MI COMBOBOX
            
            cmbOBRA_SOCIAL.ValueMember = "ID_OBRA_SOCIAL";
            cmbOBRA_SOCIAL.DisplayMember = "NOMBRE";
            cmbOBRA_SOCIAL.DataSource = cOBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES();

            MODO_DATOS();
        }

        private void cmbOBRA_SOCIAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID_OBRA_SOCIAL = Convert.ToInt32(cmbOBRA_SOCIAL.SelectedValue);
            ARMA_COMBOBOX_PLAN(ID_OBRA_SOCIAL);
            return;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PACIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un paciente de la lista para poder asignar la obra social junto con el plan", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPACIENTE = (MODELO.USUARIO)dgvLISTA_PACIENTES.CurrentRow.DataBoundItem;

            oPACIENTE.OBRA_SOCIAL = (MODELO.OBRA_SOCIAL)cmbOBRA_SOCIAL.SelectedItem;
            oPACIENTE.PLAN = (MODELO.PLAN)cmbPLAN.SelectedItem;

            cPACIENTES.MODIFICAR_USUARIO(oPACIENTE);

            ARMA_GRILLA();
            MODO_GRILLA();

            cmbOBRA_SOCIAL.Text = null;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            MODO_GRILLA();
            cmbOBRA_SOCIAL.Text = null;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
