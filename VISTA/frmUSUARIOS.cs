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
    public partial class frmUSUARIOS : Form
    {
        private static frmUSUARIOS instancia;

        public static frmUSUARIOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmUSUARIOS();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmUSUARIOS();
            }
            return instancia;
        }

        public frmUSUARIOS()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();           
            
            ARMA_GRILLA("A");
            MODO_GRILLA();

            cmbROL.Items.Add("SELECCIONE...");
            cmbROL.SelectedItem = "SELECCIONE...";
            cmbROL.Items.Add("ADMINISTRADOR");
            cmbROL.Items.Add("PACIENTE");
            cmbROL.Items.Add("PROFESIONAL");
            cmbROL.Items.Add("JEFE DE COMPRAS");

            cmbFILTRO_TIPO.Items.Add("TODOS");
            cmbFILTRO_TIPO.SelectedItem = "TODOS";
            cmbFILTRO_TIPO.Items.Add("ADMINISTRADOR");
            cmbFILTRO_TIPO.Items.Add("PACIENTE");
            cmbFILTRO_TIPO.Items.Add("PROFESIONAL");
            cmbFILTRO_TIPO.Items.Add("JEFE DE COMPRAS");
        }

        private CONTROLADORA.USUARIOS cUSUARIOS;
        private MODELO.USUARIO oUSUARIO;
        string ACCION;

        private void ARMA_GRILLA(string TIPO)
        {
            if (TIPO == "A")
            {
                dgvLISTA_USUARIOS.DataSource = null;
                dgvLISTA_USUARIOS.DataSource = cUSUARIOS.OBTENER_USUARIOS();
            }
            if (TIPO == "B")
            {
                string FILTRO_TIPO_USUARIO = cmbFILTRO_TIPO.Text;

                if (FILTRO_TIPO_USUARIO == "TODOS")
                {
                    dgvLISTA_USUARIOS.DataSource = null;
                    dgvLISTA_USUARIOS.DataSource = cUSUARIOS.OBTENER_USUARIOS();
                }
                else
                {
                    var LISTA_TIPOS_USUARIO = (from a in cUSUARIOS.OBTENER_USUARIOS()
                                       where a.TIPO == FILTRO_TIPO_USUARIO
                                       select a).ToList();

                    dgvLISTA_USUARIOS.DataSource = null;
                    dgvLISTA_USUARIOS.DataSource = LISTA_TIPOS_USUARIO;
                }
            }           

            dgvLISTA_USUARIOS.AutoGenerateColumns = false;
            if (dgvLISTA_USUARIOS.Columns.Contains("ESPECIALIDADES"))
            {
                dgvLISTA_USUARIOS.Columns.Remove("ESPECIALIDADES");
            }        
        }

        private void MODO_GRILLA()
        {
            gbLISTA_USUARIOS.Enabled = true;
            gbDATOS_USUARIO.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_USUARIOS.Enabled = false;
            gbDATOS_USUARIO.Enabled = true;

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

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            oUSUARIO = new MODELO.USUARIO();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES

            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del usuario para poder registrar el usuario", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtAPELLIDO.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del usuario para poder registrar el usuario", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }        

            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("Debe ingresar el email del usuario para poder registrar el usuario", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!EMAIL_BIEN_ESCRITO(txtEMAIL.Text))
            {
                MessageBox.Show("El mail es incorrecto", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           

            if (string.IsNullOrWhiteSpace(txtPASSWORD.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña para registrar el usuario", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCONFIRMAR_PASSWORD.Text))
            {
                MessageBox.Show("Debe confirmar la contraseña para registrar el usuario ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbROL.SelectedItem == "SELECCIONE...")
            {
                MessageBox.Show("Debe seleccionar un rol para poder registrar el usuario", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPASSWORD.TextLength < 8 || txtCONFIRMAR_PASSWORD.TextLength < 8)
            {
                MessageBox.Show("La contraseña debe contener entre 8 y 16 caracteres", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtPASSWORD.TextLength > 16 || txtCONFIRMAR_PASSWORD.TextLength > 16)
            {
                MessageBox.Show("La contraseña debe contener entre 8 y 16 caracteres", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }               
            #endregion

            // ASIGNO MI TEXTBOX CON MI PROPIEDAD
            oUSUARIO.NOMBRE = txtNOMBRE.Text.ToUpper();// Uso la funcion ToUapper para escribir el nombre en mayúscula
            oUSUARIO.APELLIDO = txtAPELLIDO.Text.ToUpper();
            oUSUARIO.EMAIL = txtEMAIL.Text;
            oUSUARIO.CLAVE = txtPASSWORD.Text;
            oUSUARIO.FECHA = DateTime.Now;           
            oUSUARIO.TIPO = cmbROL.SelectedItem.ToString();
            
            if (txtPASSWORD.Text == txtCONFIRMAR_PASSWORD.Text)
            {
                if (ACCION == "A")
                {
                    cUSUARIOS.AGREGAR_USUARIO(oUSUARIO);              
                }
                else if(ACCION == "M")
                {
                    cUSUARIOS.MODIFICAR_USUARIO(oUSUARIO);
                }
                // LIMPIO LA TEXTBOX         
                txtNOMBRE.Clear();
                txtAPELLIDO.Clear();
                txtEMAIL.Clear();
                txtPASSWORD.Clear();
                txtCONFIRMAR_PASSWORD.Clear();
                cmbROL.SelectedItem = "SELECCIONE...";

                ARMA_GRILLA("B");
                MODO_GRILLA();         
            }
            else
            {
                MessageBox.Show("Las contraseñas deben ser las mismas para registrar un nuevo usuario", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_USUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oUSUARIO = (MODELO.USUARIO)dgvLISTA_USUARIOS.CurrentRow.DataBoundItem;

            
            /*string TIPO = "";
            foreach (DataGridViewRow row in dgvLISTA_USUARIOS.SelectedRows)
            {
                TIPO = (string)row.Cells["TIPO"].Value;
            }

            if (TIPO == "PACIENTE")
            {
                MessageBox.Show("No puede modificar un usuario de tipo paciente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            ACCION = "M";

            txtNOMBRE.Text = oUSUARIO.NOMBRE.ToUpper();
            txtAPELLIDO.Text = oUSUARIO.APELLIDO.ToUpper();
            txtEMAIL.Text = oUSUARIO.EMAIL;
            txtPASSWORD.Text = oUSUARIO.CLAVE;
            cmbROL.SelectedItem = oUSUARIO.TIPO.ToString();

            MODO_DATOS();
        }

        private void btnCONSULTAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_USUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oUSUARIO = (MODELO.USUARIO)dgvLISTA_USUARIOS.CurrentRow.DataBoundItem;

            ACCION = "C";

            txtNOMBRE.Text = oUSUARIO.NOMBRE.ToUpper();
            txtAPELLIDO.Text = oUSUARIO.APELLIDO.ToUpper();
            txtEMAIL.Text = oUSUARIO.EMAIL;
            txtPASSWORD.Text = oUSUARIO.CLAVE;
            cmbROL.SelectedItem = oUSUARIO.TIPO.ToString();

            MODO_DATOS();
        }

        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_USUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oUSUARIO = (MODELO.USUARIO)dgvLISTA_USUARIOS.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Esta seguro de eliminar el usuario " + oUSUARIO.NOMBRE + " " + oUSUARIO.APELLIDO + " de la lista de usuarios?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (RESPUESTA == DialogResult.Yes)
            {
                cUSUARIOS.ELIMINAR_USUARIO(oUSUARIO);
                ARMA_GRILLA("A");
            }
        }

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            txtAPELLIDO.Clear();
            txtEMAIL.Clear();
            txtPASSWORD.Clear();
            txtCONFIRMAR_PASSWORD.Clear();
            cmbROL.SelectedItem = "SELECCIONE...";
            MODO_GRILLA();
        }

        private void btnCERRAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbFILTRO_TIPO.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }          
                ARMA_GRILLA("B");          
        }

        private void txtNOMBRE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAPELLIDO_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
    }
}
