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
    public partial class frmREGISTRO_PACIENTE : Form
    {
        private static frmREGISTRO_PACIENTE instancia;

        public static frmREGISTRO_PACIENTE OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmREGISTRO_PACIENTE();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmREGISTRO_PACIENTE();
            }
            return instancia;
        }

        private CONTROLADORA.USUARIOS cUSUARIOS;
        private MODELO.USUARIO oUSUARIO;

        public frmREGISTRO_PACIENTE()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            
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

        private void lonklblLOGIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLOGIN FORMULARIO_LOGIN = frmLOGIN.OBTENER_INSTANCIA();
            this.Hide();
            FORMULARIO_LOGIN.ShowDialog();
            
        }

        private void btnREGISTRAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre para poder registrarse", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAPELLIDO.Text))
            {
                MessageBox.Show("Debe ingresar el apellido para poder registrarse", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEMAIL.Text))
            {
                MessageBox.Show("Debe ingresar el email para poder registrarse", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!EMAIL_BIEN_ESCRITO(txtEMAIL.Text))
            {
                MessageBox.Show("El mail es incorrecto", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPASSWORD.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña para poder registrarse", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCONFIRMAR_PASSWORD.Text))
            {
                MessageBox.Show("Debe ingresar la confirmacion de su contraseña para poder registrarse", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            oUSUARIO = new MODELO.USUARIO();

            // ASIGNO MI TEXTBOX CON MI PROPIEDAD
            oUSUARIO.NOMBRE = txtNOMBRE.Text.ToUpper();
            oUSUARIO.APELLIDO = txtAPELLIDO.Text.ToUpper();
            oUSUARIO.EMAIL = txtEMAIL.Text;
            oUSUARIO.FECHA = DateTime.Now;
            oUSUARIO.CLAVE = txtPASSWORD.Text;
            oUSUARIO.TIPO = "PACIENTE";
            
            //dgvLISTA_ESPECIALIDADES.DataSource = cUSUARIOS.OBTENER_USUARIOS();
            

            if (txtPASSWORD.Text == txtCONFIRMAR_PASSWORD.Text)
            {
                cUSUARIOS.AGREGAR_USUARIO(oUSUARIO);
                frmLOGIN FORMULARIO_LOGIN = new frmLOGIN();
                this.Hide();
                FORMULARIO_LOGIN.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingresar la misma contraseña para registrarse", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
    }
}
