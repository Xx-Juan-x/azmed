using CONTROLADORA;
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
    public partial class frmPACIENTES : Form
    {
        //PATRON SINGLETON
        private static frmPACIENTES instancia;

        public static frmPACIENTES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmPACIENTES();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmPACIENTES();
            }
            return instancia;
        }

        private CONTROLADORA.PACIENTES cPACIENTES;
        private MODELO.PACIENTE oPACIENTE;
        private CONTROLADORA.OBRAS_SOCIALES cOBRAS_SOCIALES;
        private CONTROLADORA.PLANES cPLANES;
        string ACCION;

        public frmPACIENTES()
        {
            InitializeComponent();
            cPACIENTES = CONTROLADORA.PACIENTES.OBTENER_INSTANCIA();
            cOBRAS_SOCIALES = CONTROLADORA.OBRAS_SOCIALES.OBTENER_INSTANCIA();
            cPLANES = CONTROLADORA.PLANES.OBTENER_INSTANCIA();

            ARMA_COMBOBOX_OBRA_SOCIAL();
            ARMA_GRILLA("A");
            MODO_GRILLA();
        }

        private void ARMA_GRILLA(string TIPO)
        {
            if (TIPO == "A")
            {
                dgvLISTA_PACIENTES.DataSource = null;
                dgvLISTA_PACIENTES.DataSource = cPACIENTES.OBTENER_PACIENTES();
                List<MODELO.OBRA_SOCIAL> obras_sociales = cOBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES();
                MODELO.OBRA_SOCIAL obra = new MODELO.OBRA_SOCIAL();
                obra.NOMBRE = "TODOS";
                obra.ID_OBRA_SOCIAL = 0;

                obras_sociales.Insert(0, obra);
                cmbFILTRO_OBRA_SOCIAL.DataSource = obras_sociales;
            }
            if (TIPO == "B")
            {
                string FILTRO_PACIENTE = cmbFILTRO_OBRA_SOCIAL.Text;

                if (FILTRO_PACIENTE == "TODOS")
                {
                    dgvLISTA_PACIENTES.DataSource = null;
                    dgvLISTA_PACIENTES.DataSource = cPACIENTES.OBTENER_PACIENTES();
                    
                }
                else
                {
                    var FILTRO_OBRA_SOCIAL_PACIENTE = (from a in cPACIENTES.OBTENER_PACIENTES()
                                                where a.OBRA_SOCIAL.NOMBRE == FILTRO_PACIENTE
                                                select a).ToList();

                    dgvLISTA_PACIENTES.DataSource = null;
                    dgvLISTA_PACIENTES.DataSource = FILTRO_OBRA_SOCIAL_PACIENTE;
                    
                }
            }
        }
        private void MODO_GRILLA()
        {
            gbLISTA_PACIENTES.Enabled = true;
            gbDATOS_PACIENTE.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_PACIENTES.Enabled = false;
            gbDATOS_PACIENTE.Enabled = true;

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
                                where c.OBRA_SOCIAL.ID_OBRA_SOCIAL == ID_OBRA_SOCIAL && c.ESTADO != "INACTIVO"
                                select c).ToList();

            cmbPLAN.DataSource = LISTA_PLANES;
            cmbPLAN.ValueMember = "ID_PLAN";
            cmbPLAN.DisplayMember = "NOMBRE";
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            oPACIENTE = new MODELO.PACIENTE();
            ACCION = "A";

            cmbOBRA_SOCIAL.DataSource = null;

            //AÑADO MI PROPIEDAD OBRA SOCIAL A MI COMBOBOX
            cmbOBRA_SOCIAL.ValueMember = "ID_OBRA_SOCIAL";
            cmbOBRA_SOCIAL.DisplayMember = "NOMBRE";
            cmbOBRA_SOCIAL.DataSource = cOBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES();

            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del paciente para poder registrarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtAPELLIDO.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del paciente para poder registrarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int64 CONTACTO;
            if (!Int64.TryParse(txtCONTACTO.Text, out CONTACTO))
            {
                MessageBox.Show("Debe ingresar un contacto de forma correcta para poder registrar al paciente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCONTACTO.TextLength <= 5)
            {
                MessageBox.Show("El contacto es demasiado corto", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtCONTACTO.TextLength > 14)
            {
                MessageBox.Show("El contacto es demasiado largo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("Debe ingresar el email del paciente para poder registrarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!EMAIL_BIEN_ESCRITO(txtEMAIL.Text))
            {
                MessageBox.Show("El mail es incorrecto", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbOBRA_SOCIAL.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una obra social para poder registrar el paciente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPLAN.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un plan para poder registrar el paciente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            //ASIGNO MIS CONTROLES CON MIS ATRIBUTOS DEL MODELO
            oPACIENTE.NOMBRE = txtNOMBRE.Text.ToUpper();
            oPACIENTE.APELLIDO = txtAPELLIDO.Text.ToUpper();
            oPACIENTE.CONTACTO = CONTACTO;
            oPACIENTE.EMAIL = txtEMAIL.Text;
            oPACIENTE.FECHA = DateTime.Now;
            oPACIENTE.OBRA_SOCIAL = (MODELO.OBRA_SOCIAL)cmbOBRA_SOCIAL.SelectedItem;
            oPACIENTE.PLAN = (MODELO.PLAN)cmbPLAN.SelectedItem;

            if (ACCION == "A")
            {
                cPACIENTES.AGREGAR_PACIENTE(oPACIENTE);
            }
            else if (ACCION == "M")
            {
                cPACIENTES.MODIFICAR_PACIENTE(oPACIENTE);
            }
            else if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            }

            // LIMPIO LA TEXTBOX         
            txtNOMBRE.Clear();
            txtAPELLIDO.Clear();
            txtCONTACTO.Clear();
            txtEMAIL.Clear();
            
            MODO_GRILLA();
            ARMA_GRILLA("A");
        }

        private void cmbOBRA_SOCIAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID_OBRA_SOCIAL = Convert.ToInt32(cmbOBRA_SOCIAL.SelectedValue);
            ARMA_COMBOBOX_PLAN(ID_OBRA_SOCIAL);
            return;
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbFILTRO_OBRA_SOCIAL.Text))
            {
                MessageBox.Show("Debe seleccionar un paciente de la lista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ARMA_GRILLA("B");
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PACIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un paciente de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPACIENTE = (MODELO.PACIENTE)dgvLISTA_PACIENTES.CurrentRow.DataBoundItem;

            ACCION = "M";

            txtNOMBRE.Text = oPACIENTE.NOMBRE.ToUpper();
            txtAPELLIDO.Text = oPACIENTE.APELLIDO.ToUpper();
            txtCONTACTO.Text = oPACIENTE.CONTACTO.ToString();
            txtEMAIL.Text = oPACIENTE.EMAIL;

            cmbOBRA_SOCIAL.ValueMember = "ID_OBRA_SOCIAL";
            cmbOBRA_SOCIAL.DisplayMember = "NOMBRE";
            cmbOBRA_SOCIAL.DataSource = cOBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES();

            cmbOBRA_SOCIAL.Text = oPACIENTE.OBRA_SOCIAL.ToString();
            cmbPLAN.Text = oPACIENTE.PLAN.ToString();


            MODO_DATOS();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PACIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un paciente de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPACIENTE = (MODELO.PACIENTE)dgvLISTA_PACIENTES.CurrentRow.DataBoundItem;

            ACCION = "C";

            txtNOMBRE.Text = oPACIENTE.NOMBRE.ToUpper();
            txtAPELLIDO.Text = oPACIENTE.APELLIDO.ToUpper();
            txtCONTACTO.Text = oPACIENTE.CONTACTO.ToString();
            txtEMAIL.Text = oPACIENTE.EMAIL;

            cmbOBRA_SOCIAL.ValueMember = "ID_OBRA_SOCIAL";
            cmbOBRA_SOCIAL.DisplayMember = "NOMBRE";
            cmbOBRA_SOCIAL.DataSource = cOBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES();

            cmbOBRA_SOCIAL.Text = oPACIENTE.OBRA_SOCIAL.ToString();
            cmbPLAN.Text = oPACIENTE.PLAN.ToString();

            MODO_DATOS();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PACIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un paciente de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPACIENTE = (MODELO.PACIENTE)dgvLISTA_PACIENTES.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar el paciente " + oPACIENTE.NOMBRE + " " + oPACIENTE.APELLIDO + " de la lista de pacientes?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cPACIENTES.ELIMINAR_PACIENTE(oPACIENTE);
                ARMA_GRILLA("A");
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            txtAPELLIDO.Clear();
            txtCONTACTO.Clear();
            txtEMAIL.Clear();

            MODO_GRILLA();
            ARMA_COMBOBOX_OBRA_SOCIAL();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAPELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCONTACTO_KeyPress(object sender, KeyPressEventArgs e)
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
