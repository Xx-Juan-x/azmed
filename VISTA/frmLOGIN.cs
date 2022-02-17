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
    public partial class frmLOGIN : Form
    {
        private CONTROLADORA.USUARIOS cUSUARIOS;      
        public static string TIPO_USUARIO = "";

        public frmLOGIN()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
        }

        private void linklblREGISTRARSE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmREGISTRO_PACIENTE FORMULARIO_REGISTRO = frmREGISTRO_PACIENTE.OBTENER_INSTANCIA();
            this.Hide();
            FORMULARIO_REGISTRO.Show();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool VALIDAR_LOGIN(string EMAIL, string CLAVE)
        {
            var RESPUESTA = from d in cUSUARIOS.OBTENER_USUARIOS()
                    where d.EMAIL == EMAIL
                    && d.CLAVE == CLAVE
                    select d;

            if (RESPUESTA.Any())
            {
                RESPUESTA.ToList().ForEach(s => TIPO_USUARIO = s.TIPO);
                return true;
            }
            else
            {
                if (string.IsNullOrEmpty(txtEMAIL.Text))
                {
                    MessageBox.Show("Debe completar el email para poder ingresar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txtCLAVE.Text))
                {
                    MessageBox.Show("Debe completar la clave para poder ingresar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Email y Contraseña incorrectos", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);                  
                }
                return false;
            }
        }
        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            if (VALIDAR_LOGIN(txtEMAIL.Text, txtCLAVE.Text))
            {
                frmCLINICA FORMULARIO_CLINICA = frmCLINICA.OBTENER_INSTANCIA();
                FORMULARIO_CLINICA.Show();
                txtEMAIL.Clear();
                txtCLAVE.Clear();
            }
        }
    }
}
