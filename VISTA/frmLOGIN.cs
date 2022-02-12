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

        private void btnINGRESAR_Click_1(object sender, EventArgs e)
        {
            oUSUARIO = new MODELO.USUARIO();
            oUSUARIO.EMAIL = txtEMAIL.Text;
            oUSUARIO.CLAVE = txtCLAVE.Text;
            cUSUARIOS.OBTENER_USUARIO(txtEMAIL.Text, txtCLAVE.Text);
        }
    }
}
