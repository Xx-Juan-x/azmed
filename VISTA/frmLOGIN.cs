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
        public static CONTROLADORA.GRUPOS cGRUPOS;
        private CONTROLADORA.AUDITORIAS cAUDITORIAS;
        private MODELO.AUDITORIA_LOGIN_LOGOUT oAUDITORIA;
        public static string TIPO_USUARIO = "";
        public static int ID_USUARIO; 
        public static int ID_PROFESIONAL = 0;
        public static string NOMBRE_USUARIO;

        public frmLOGIN()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            cGRUPOS = CONTROLADORA.GRUPOS.OBTENER_INSTANCIA();
            cAUDITORIAS = CONTROLADORA.AUDITORIAS.OBTENER_INSTANCIA();
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
                    NOMBRE_USUARIO = RESPUESTA[0].NOMBRE;
                    if(RESPUESTA[0].PROFESIONAL != null)
                    {
                        ID_PROFESIONAL = RESPUESTA[0].PROFESIONAL.ID_PROFESIONAL;
                    } 
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
                
                REGISTRAR_INICIO_SESION_EXITOSO(txtEMAIL.Text);
                frmCLINICA FORMULARIO_CLINICA = frmCLINICA.OBTENER_INSTANCIA();
                FORMULARIO_CLINICA.Show();
                txtEMAIL.Clear();
                txtCLAVE.Clear();
                this.Hide();
                
            }
        }

        //AUDITORIA DE LOGIN
        private void REGISTRAR_INICIO_SESION_EXITOSO(string USUARIO)
        {
            var EMAIL_USUARIO = cUSUARIOS.OBTENER_USUARIOS().FirstOrDefault(u => u.EMAIL == USUARIO);
            if (EMAIL_USUARIO != null)
            {
                oAUDITORIA = new MODELO.AUDITORIA_LOGIN_LOGOUT();

                oAUDITORIA.USUARIO = EMAIL_USUARIO.EMAIL;
                oAUDITORIA.FECHA_HORA = DateTime.Now;
                oAUDITORIA.ACCION = "Inicio de sesión exitoso";
                oAUDITORIA.DATOS_REGISTRADOS = "LOGUEO";

                cAUDITORIAS.AGREGAR_AUDITORIA(oAUDITORIA);              
            }
        }
    }
}
