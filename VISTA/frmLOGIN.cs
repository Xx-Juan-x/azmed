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
        private MODELO.USUARIO oUSUARIO;

        public frmLOGIN()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
        }

        private void linklblREGISTRARSE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmREGISTRO_PACIENTE FORMULARIO_REGISTRO = new frmREGISTRO_PACIENTE();
            this.Hide();
            FORMULARIO_REGISTRO.ShowDialog();
            
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            oUSUARIO = new MODELO.USUARIO();
            cUSUARIOS.OBTENER_EMAIL(txtEMAIL.Text);
            cUSUARIOS.OBTENER_CLAVE(txtCLAVE.Text);
            //oUSUARIO.EMAIL = txtEMAIL.Text;
            //oUSUARIO.CLAVE = txtCLAVE.Text;
            

            if (txtEMAIL.Text == oUSUARIO.EMAIL && txtCLAVE.Text == oUSUARIO.CLAVE)
            {
                frmCLINICA FORMULARIO_CLINICA = new frmCLINICA();
                FORMULARIO_CLINICA.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingresar el email o la contraseña de forma correcta", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
        }
    }
}
