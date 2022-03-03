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
    public partial class frmPLAN : Form
    {
        //PATRON SINGLETON
        private static frmPLAN instancia;

        public static frmPLAN OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmPLAN();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmPLAN();
            }
            return instancia;
        }

        private CONTROLADORA.PLANES cPLANES;
        private CONTROLADORA.OBRAS_SOCIALES cOBRAS_SOCIALES;
        private MODELO.OBRA_SOCIAL oOBRA_SOCIAL;
        private MODELO.PLAN oPLAN;
        string ACCION;

        public frmPLAN()
        {
            InitializeComponent();
            cPLANES = CONTROLADORA.PLANES.OBTENER_INSTANCIA();
            cOBRAS_SOCIALES = CONTROLADORA.OBRAS_SOCIALES.OBTENER_INSTANCIA();

            cmbPLANES.Items.Add("SELECCIONE...");
            cmbPLANES.SelectedItem = "SELECCIONE...";
            cmbPLANES.Items.Add("BASICO");
            cmbPLANES.Items.Add("SUPERADOR");
            cmbPLANES.Items.Add("PREMIUM");
            cmbPLANES.Items.Add("JUBILADOS");
            cmbPLANES.Items.Add("ESTUDIANTE");

            cmbOBRA_SOCIAL.Items.Add("SELECCIONE...");
            cmbOBRA_SOCIAL.SelectedItem = "SELECCIONE...";

            ARMA_GRILLA();
            MODO_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_PLANES.DataSource = null;
            dgvLISTA_PLANES.DataSource = cPLANES.OBTENER_PLANES();
        }

        private void MODO_GRILLA()
        {
            gbLISTA_PLANES.Enabled = true;
            gbDATOS_PLAN.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_PLANES.Enabled = false;
            gbDATOS_PLAN.Enabled = true;

            // LIMPIO MI COMBOBOX 
            cmbOBRA_SOCIAL.DataSource = null;

            //AÑADO MI PROPIEDAD OBRA SOCIAL A MI PLAN
            cmbOBRA_SOCIAL.DataSource = cOBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES();
            cmbOBRA_SOCIAL.DisplayMember = "NOMBRE";

            if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            }
            else
            {
                btnGUARDAR.Enabled = true;
            }
        }

        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            oPLAN = new MODELO.PLAN();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click_1(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (cmbOBRA_SOCIAL.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una obra social para poder agregar un plan", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPLANES.SelectedItem == "SELECCIONE...")
            {
                MessageBox.Show("Debe seleccionar el plan que va a tener la obra social", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int TIPO_PLAN;
            if (!int.TryParse(txtTIPO_PLAN.Text, out TIPO_PLAN))
            {
                MessageBox.Show("Debe ingresar el tipo de plan a la lista de planes", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            oPLAN.NOMBRE = cmbPLANES.Text; // Uso la funcion ToUapper para escribir el nombre en mayúscula
            oPLAN.TIPO = TIPO_PLAN;
            oPLAN.OBRA_SOCIAL = (MODELO.OBRA_SOCIAL)cmbOBRA_SOCIAL.SelectedItem;

            if (ACCION == "A")
            {
                cPLANES.AGREGAR_PLAN(oPLAN);
            }
            else
            {
                cPLANES.MODIFICAR_PLAN(oPLAN);
            }

            // LIMPIO LA TEXTBOX
            cmbPLANES.Text = "SELECCIONE...";
            txtTIPO_PLAN.Clear();
            cmbOBRA_SOCIAL.SelectedItem = null;
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void btnMODIFICAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_PLANES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plan de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPLAN = (MODELO.PLAN)dgvLISTA_PLANES.CurrentRow.DataBoundItem;

            ACCION = "M";

            //ASIGNO EL CONTENIDO DE LOS CAMPOS CON MIS OBJETOS CORRESPONDIENTES
            cmbPLANES.Text = oPLAN.NOMBRE;
            txtTIPO_PLAN.Text = oPLAN.TIPO.ToString();
            MODO_DATOS();
            cmbOBRA_SOCIAL.SelectedItem = oPLAN.OBRA_SOCIAL;
        }

        private void btnCONSULTAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_PLANES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plan de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPLAN = (MODELO.PLAN)dgvLISTA_PLANES.CurrentRow.DataBoundItem;

            ACCION = "C";

            cmbPLANES.Text = oPLAN.NOMBRE;
            txtTIPO_PLAN.Text = oPLAN.TIPO.ToString();
            MODO_DATOS();
            cmbOBRA_SOCIAL.SelectedItem = oPLAN.OBRA_SOCIAL;
        }

        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_PLANES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plan de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPLAN = (MODELO.PLAN)dgvLISTA_PLANES.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar el plan " + oPLAN.NOMBRE + " de la lista de planes?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cPLANES.ELIMINAR_PLAN(oPLAN);
                ARMA_GRILLA();
            }

        }

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            cmbPLANES.Text = "SELECCIONE...";          
            txtTIPO_PLAN.Clear();
            cmbOBRA_SOCIAL.SelectedItem = null;
            MODO_GRILLA();
        }

        private void btnCERRAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTIPO_PLAN_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }       
    }
}
