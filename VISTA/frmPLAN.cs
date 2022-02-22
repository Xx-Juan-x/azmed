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
            cmbOBRA_SOCIAL.DisplayMember = "TIPO_OBRA_SOCIAL";

            if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            }
            else
            {
                btnGUARDAR.Enabled = true;
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            oPLAN = new MODELO.PLAN();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (cmbOBRA_SOCIAL.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una obra social para poder agregar un plan", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del plan a la lista de planes", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int TIPO_PLAN;
            if (!int.TryParse(txtTIPO_PLAN.Text, out TIPO_PLAN))
            {
                MessageBox.Show("Debe ingresar el tipo de plan a la lista de planes", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            oPLAN.NOMBRE = txtNOMBRE.Text.ToUpper(); // Uso la funcion ToUapper para escribir el nombre en mayúscula
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
            txtNOMBRE.Clear();
            txtTIPO_PLAN.Clear();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PLANES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plan de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPLAN = (MODELO.PLAN)dgvLISTA_PLANES.CurrentRow.DataBoundItem;

            ACCION = "M";

            //ASIGNO EL CONTENIDO DE LOS CAMPOS CON MIS OBJETOS CORRESPONDIENTES
            txtNOMBRE.Text = oPLAN.NOMBRE;
            txtTIPO_PLAN.Text = oPLAN.TIPO.ToString();
            cmbOBRA_SOCIAL.SelectedItem = oPLAN.OBRA_SOCIAL;

            MODO_DATOS();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PLANES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plan de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPLAN = (MODELO.PLAN)dgvLISTA_PLANES.CurrentRow.DataBoundItem;

            ACCION = "C";

            txtNOMBRE.Text = oPLAN.NOMBRE;
            txtTIPO_PLAN.Text = oPLAN.TIPO.ToString();
            cmbOBRA_SOCIAL.SelectedItem = oPLAN.OBRA_SOCIAL;

            MODO_DATOS();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
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

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            txtTIPO_PLAN.Clear();
            MODO_GRILLA();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
