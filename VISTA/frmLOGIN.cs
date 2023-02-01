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
        private static frmLOGIN instancia;

        public static frmLOGIN OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmLOGIN();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmLOGIN();
            }
            return instancia;
        }

        private CONTROLADORA.USUARIOS cUSUARIOS;
        //private CONTROLADORA.PLANES cPLANES;
        public static CONTROLADORA.GRUPOS cGRUPOS;
        public static string TIPO_USUARIO = "";
        public static int ID_USUARIO; 
        //public frmREGISTRO_PACIENTE FORMULARIO_REGISTRO;
        //public static double DESCUENTO_ESTUDIO;
        //public static double DESCUENTO_CONSULTA;

        public frmLOGIN()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            cGRUPOS = CONTROLADORA.GRUPOS.OBTENER_INSTANCIA();
            //cPLANES = CONTROLADORA.PLANES.OBTENER_INSTANCIA();
        }

        private void linklblREGISTRARSE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FORMULARIO_REGISTRO = frmREGISTRO_PACIENTE.OBTENER_INSTANCIA();
            this.Hide();        
            //FORMULARIO_REGISTRO.Show();        
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {       
            Application.Exit();
        }

        private bool VALIDAR_LOGIN(string EMAIL, string CLAVE)
        {
            var RESPUESTA = (from d in cUSUARIOS.OBTENER_USUARIOS()
                             where d.EMAIL == EMAIL
                             && d.CLAVE == CLAVE
                             select d).ToList();

            if (RESPUESTA.Any())
            {
                var usuario = RESPUESTA.ToList();
                if (usuario[0].ESTADO == "ACTIVO")
                {
                    TIPO_USUARIO = RESPUESTA[0].GRUPO.NOMBRE;
                    ID_USUARIO = RESPUESTA[0].ID_USUARIO;

                    /*if (TIPO_USUARIO == "PACIENTE")
                    {
                        if (RESPUESTA[0].PLAN.ESTADO == "INACTIVO")
                        {
                            DESCUENTO_CONSULTA = 0;
                            DESCUENTO_ESTUDIO = 0;
                        }
                        else
                        {
                            DESCUENTO_CONSULTA = RESPUESTA[0].PLAN.DESCUENTO_CONSULTA;
                            DESCUENTO_ESTUDIO = RESPUESTA[0].PLAN.DESCUENTO_ESTUDIO;
                        }
                    }*/
                    return true;
                }
                else
                {
                    MessageBox.Show("El usuario esta INACTIVO, contactar al administrador para mas informacion", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
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
                this.Hide();
            }
        }
    }
}
