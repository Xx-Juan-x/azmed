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

        private void lonklblLOGIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLOGIN FORMULARIO_LOGIN = new frmLOGIN();
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
            #endregion

            oUSUARIO = new MODELO.USUARIO();

            // ASIGNO MI TEXTBOX CON MI PROPIEDAD
            oUSUARIO.NOMBRE = txtNOMBRE.Text.ToUpper();
            oUSUARIO.APELLIDO = txtAPELLIDO.Text.ToUpper();
            oUSUARIO.EMAIL = txtEMAIL.Text.ToUpper();
            oUSUARIO.FECHA = DateTime.Now;
            oUSUARIO.CLAVE = txtPASSWORD.Text;
            oUSUARIO.TIPO = "PACIENTE";

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
    }
}
