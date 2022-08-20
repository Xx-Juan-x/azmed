using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

            /*cmbPLANES.Items.Add("SELECCIONE...");
            cmbPLANES.SelectedItem = "SELECCIONE...";
            cmbPLANES.Items.Add("BASICO");
            cmbPLANES.Items.Add("SUPERADOR");
            cmbPLANES.Items.Add("PREMIUM");
            cmbPLANES.Items.Add("JUBILADOS");
            cmbPLANES.Items.Add("ESTUDIANTE");*/

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

            if (string.IsNullOrWhiteSpace(txtPLAN.Text))
            {
                MessageBox.Show("Debe ingresar un plan para asignarlo con la Obra Social", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double DESCUENTO_CONSULTA;
            if (!double.TryParse(txtDESCUENTO_CONSULTA.Text, out DESCUENTO_CONSULTA))
            {
                MessageBox.Show("Debe ingresar un descuento de consulta al plan de forma correcta", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double DESCUENTO_ESTUDIO;
            if (!double.TryParse(txtDESCUENTO_ESTUDIO.Text, out DESCUENTO_ESTUDIO))
            {
                MessageBox.Show("Debe ingresar un descuento de estudio al plan de forma correcta", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            oPLAN.NOMBRE = txtPLAN.Text.ToUpper(); // Uso la funcion ToUapper para escribir el nombre en mayúscula
            oPLAN.OBRA_SOCIAL = (MODELO.OBRA_SOCIAL)cmbOBRA_SOCIAL.SelectedItem;
            oPLAN.DESCUENTO_CONSULTA = DESCUENTO_CONSULTA;
            oPLAN.DESCUENTO_ESTUDIO = DESCUENTO_ESTUDIO;

            if (ACCION == "A")
            {
                oPLAN.ESTADO = "HABILITADO";
                cPLANES.AGREGAR_PLAN(oPLAN);
            }
            else
            {
                cPLANES.MODIFICAR_PLAN(oPLAN);
            }

            // LIMPIO LA TEXTBOX
            txtPLAN.Clear();
            cmbOBRA_SOCIAL.SelectedItem = null;
            txtDESCUENTO_CONSULTA.Clear();
            txtDESCUENTO_ESTUDIO.Clear();
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
            txtPLAN.Text = oPLAN.NOMBRE.ToUpper();
            cmbOBRA_SOCIAL.SelectedItem = oPLAN.OBRA_SOCIAL;
            txtDESCUENTO_CONSULTA.Text = oPLAN.DESCUENTO_CONSULTA.ToString();
            txtDESCUENTO_ESTUDIO.Text = oPLAN.DESCUENTO_ESTUDIO.ToString();
            MODO_DATOS();
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

            txtPLAN.Text = oPLAN.NOMBRE;
            cmbOBRA_SOCIAL.SelectedItem = oPLAN.OBRA_SOCIAL;
            txtDESCUENTO_CONSULTA.Text = oPLAN.DESCUENTO_CONSULTA.ToString();
            txtDESCUENTO_ESTUDIO.Text = oPLAN.DESCUENTO_ESTUDIO.ToString();
            MODO_DATOS();
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
                oPLAN.ESTADO = "INHABILITADO";
                cPLANES.MODIFICAR_PLAN(oPLAN);
                ARMA_GRILLA();
            }

        }
        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            txtPLAN.Clear();          
            cmbOBRA_SOCIAL.SelectedItem = null;
            txtDESCUENTO_CONSULTA.Clear();
            txtDESCUENTO_ESTUDIO.Clear();
            MODO_GRILLA();
        }

        private void btnCERRAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void txtPLAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDESCUENTO_CONSULTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!reg.IsMatch(e.KeyChar.ToString()) && !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números y comas", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDESCUENTO_ESTUDIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!reg.IsMatch(e.KeyChar.ToString()) && !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números y comas", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
