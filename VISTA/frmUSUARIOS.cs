using MODELO;
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

        private CONTROLADORA.USUARIOS cUSUARIOS;
        private CONTROLADORA.PROFESIONALES cPROFESIONALES;
        private MODELO.USUARIO oUSUARIO;
        private CONTROLADORA.GRUPOS cGRUPOS;
        private MODELO.GRUPO oGRUPO;
        private MODELO.PROFESIONAL oPROFESIONAL;
        private CONTROLADORA.AUDITORIAS cAUDITORIAS;
        private MODELO.AUDITORIA oAUDITORIA;
        string ACCION;

        public frmUSUARIOS()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            cGRUPOS = CONTROLADORA.GRUPOS.OBTENER_INSTANCIA();
            cPROFESIONALES = CONTROLADORA.PROFESIONALES.OBTENER_INSTANCIA();
            cAUDITORIAS = CONTROLADORA.AUDITORIAS.OBTENER_INSTANCIA();

            ARMA_GRILLA("A");
            MODO_GRILLA();
            ARMA_COMBOBOX_GRUPO();

            cmbFILTRO_GRUPO.Items.Add("TODOS");
            cmbFILTRO_GRUPO.SelectedItem = "TODOS";
            var grupos = (from g in cGRUPOS.OBTENER_GRUPOS() select g).ToList();
            foreach (var gr in grupos)
            {
                cmbFILTRO_GRUPO.Items.Add(gr.NOMBRE);
            }
        }

        private void ARMA_GRILLA(string TIPO)
        {
            if (TIPO == "A")
            {
                dgvLISTA_USUARIOS.DataSource = null;
                dgvLISTA_USUARIOS.DataSource = (from a in cUSUARIOS.OBTENER_USUARIOS_TODOS()
                                                select a).ToList();
            }
            if (TIPO == "B")
            {
                string FILTRO_TIPO_USUARIO = cmbFILTRO_GRUPO.Text;

                if (FILTRO_TIPO_USUARIO == "TODOS")
                {
                    dgvLISTA_USUARIOS.DataSource = null;
                    dgvLISTA_USUARIOS.DataSource = (from a in cUSUARIOS.OBTENER_USUARIOS_TODOS()
                                                    select a).ToList();
                }
                else
                {
                    var FILTRO_GRUPO_USUARIO = (from a in cUSUARIOS.OBTENER_USUARIOS_TODOS()
                                                where a.GRUPO != null && a.GRUPO.NOMBRE == FILTRO_TIPO_USUARIO
                                                select a).ToList();

                    dgvLISTA_USUARIOS.DataSource = null;
                    dgvLISTA_USUARIOS.DataSource = FILTRO_GRUPO_USUARIO;
                }
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

        private void ARMA_COMBOBOX_GRUPO()
        {
            cmbGRUPO.DataSource = null;
            cmbGRUPO.Items.Add("SELECCIONE...");
            cmbGRUPO.SelectedItem = "SELECCIONE...";
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

            cmbGRUPO.ValueMember = "ID_GRUPO";
            cmbGRUPO.DisplayMember = "NOMBRE";
            cmbGRUPO.DataSource = cGRUPOS.OBTENER_GRUPOS();

            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES

            if (string.IsNullOrEmpty(txtNOMBRE_USUARIO.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del usuario para poder registrar el usuario", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (cmbGRUPO.SelectedItem.ToString() == "SELECCIONE...")
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

            if (cmbVincularProf.Text == "SELECCIONE..." && cmbVincularProf.Enabled == true)
            {
                MessageBox.Show("Debe vincular un profesional para poder gestionar un usuario", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            // ASIGNO MI TEXTBOX CON MI PROPIEDAD
            oUSUARIO.NOMBRE = txtNOMBRE_USUARIO.Text.ToUpper();// Uso la funcion ToUapper para escribir el nombre en mayúscula
            oUSUARIO.EMAIL = txtEMAIL.Text;
            oUSUARIO.CLAVE = txtPASSWORD.Text;
            oUSUARIO.FECHA = DateTime.Now;
            oUSUARIO.GRUPO = (MODELO.GRUPO)cmbGRUPO.SelectedItem;
            if (cmbGRUPO.SelectedItem.ToString() == "PROFESIONAL" && cmbVincularProf.SelectedIndex > 0)
            {
                int idPROF = cmbVincularProf.SelectedItem.GetHashCode();
                
                oPROFESIONAL = (from a in cPROFESIONALES.OBTENER_PROFESIONALES() where a.ID_PROFESIONAL ==  idPROF select a).FirstOrDefault();
                oUSUARIO.PROFESIONAL = oPROFESIONAL;
            }
            

            if (txtPASSWORD.Text == txtCONFIRMAR_PASSWORD.Text)
            {
                if (ACCION == "A")
                {
                    oUSUARIO.ESTADO = "ACTIVO";
                    cUSUARIOS.AGREGAR_USUARIO(oUSUARIO);
                    REGISTRO_AUDITORIA_USUARIO(oUSUARIO, "A");
                }
                else if (ACCION == "M")
                {
                    cUSUARIOS.MODIFICAR_USUARIO(oUSUARIO);
                    REGISTRO_AUDITORIA_USUARIO(oUSUARIO, "M");
                }
                // LIMPIO LA TEXTBOX         
                txtNOMBRE_USUARIO.Clear();
                txtEMAIL.Clear();
                txtPASSWORD.Clear();
                txtCONFIRMAR_PASSWORD.Clear();
                cmbGRUPO.SelectedItem = "SELECCIONE...";

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

            if (oUSUARIO.ESTADO == "INACTIVO")
            {
                MessageBox.Show("Debe seleccionar un usuario activo para poder modificarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ACCION = "M";

            cmbGRUPO.ValueMember = "ID_GRUPO";
            cmbGRUPO.DisplayMember = "NOMBRE";
            cmbGRUPO.DataSource = cGRUPOS.OBTENER_GRUPOS();

            txtNOMBRE_USUARIO.Text = oUSUARIO.NOMBRE.ToUpper();
            txtEMAIL.Text = oUSUARIO.EMAIL;
            txtPASSWORD.Text = oUSUARIO.CLAVE;
            if (oUSUARIO.GRUPO != null) cmbGRUPO.Text = oUSUARIO.GRUPO.ToString();

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

            cmbGRUPO.ValueMember = "ID_GRUPO";
            cmbGRUPO.DisplayMember = "NOMBRE";
            cmbGRUPO.DataSource = cGRUPOS.OBTENER_GRUPOS();

            txtNOMBRE_USUARIO.Text = oUSUARIO.NOMBRE.ToUpper();
            txtEMAIL.Text = oUSUARIO.EMAIL;
            txtPASSWORD.Text = oUSUARIO.CLAVE;
            if (oUSUARIO.GRUPO != null) cmbGRUPO.Text = oUSUARIO.GRUPO.ToString();

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

            ACCION = "E";

            DialogResult RESPUESTA = MessageBox.Show("¿Esta seguro de eliminar el usuario " + oUSUARIO.NOMBRE + " de la lista de usuarios?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (RESPUESTA == DialogResult.Yes)
            {
                oUSUARIO.ESTADO = "INACTIVO";
                cUSUARIOS.MODIFICAR_USUARIO(oUSUARIO);
                ARMA_GRILLA("A");
                REGISTRO_AUDITORIA_USUARIO(oUSUARIO, "E");
            }
        }

        //AUDITORIA DE USUARIOS
        private void REGISTRO_AUDITORIA_USUARIO(MODELO.USUARIO oUSUARIO, string TIPO_ACCION)
        {
            var REGISTRO_ACCION = cUSUARIOS.OBTENER_USUARIOS().FirstOrDefault(u => u.EMAIL == oUSUARIO.EMAIL);
            if (REGISTRO_ACCION != null)
            {
                oAUDITORIA = new MODELO.AUDITORIA();
               
                oAUDITORIA.USUARIO = oUSUARIO;
                oAUDITORIA.FECHA_HORA = DateTime.Now;

                if (ACCION == "A")
                {
                    oAUDITORIA.ACCION = "Agregar Usuario";
                    oAUDITORIA.DATOS_REGISTRADOS = "EL USUARIO " + oUSUARIO.EMAIL.ToUpper() + " FUE AGREGADO AL SISTEMA COMO UN NUEVO USUARIO";
                }
                else if (ACCION == "M")
                {
                    oAUDITORIA.ACCION = "Modificar Usuario";
                    oAUDITORIA.DATOS_REGISTRADOS = "EL USUARIO " + oUSUARIO.EMAIL.ToUpper() + " FUE MODIFICADO DEL SISTEMA";
                }
                else if (ACCION == "E")
                {
                    oAUDITORIA.ACCION = "Eliminar Usuario";
                    oAUDITORIA.DATOS_REGISTRADOS = "EL USUARIO " + oUSUARIO.EMAIL.ToUpper() + " FUE DADO DE BAJA";
                }
                else if (ACCION == "R")
                {
                    oAUDITORIA.ACCION = "Recuperar Usuario";
                    oAUDITORIA.DATOS_REGISTRADOS = "EL USUARIO " + oUSUARIO.EMAIL.ToUpper() + " FUE DADO DE ALTA";
                }

                cAUDITORIAS.AGREGAR_AUDITORIA(oAUDITORIA);
            }
        }

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            txtNOMBRE_USUARIO.Clear();
            txtEMAIL.Clear();
            txtPASSWORD.Clear();
            txtCONFIRMAR_PASSWORD.Clear();

            MODO_GRILLA();
            ARMA_COMBOBOX_GRUPO();
        }

        private void btnCERRAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbFILTRO_GRUPO.Text))
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

        private void btnRECUPERAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_USUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista para poder activarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oUSUARIO = (MODELO.USUARIO)dgvLISTA_USUARIOS.CurrentRow.DataBoundItem;
            if (oUSUARIO.ESTADO != "INACTIVO")
            {
                MessageBox.Show("Debe seleccionar un usuario inactivo para poder activarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ACCION = "R";

            DialogResult RESPUESTA = MessageBox.Show("¿Esta seguro de activar el usuario " + oUSUARIO.NOMBRE + " de la lista de usuarios?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (RESPUESTA == DialogResult.Yes)
            {
                oUSUARIO.ESTADO = "ACTIVO";
                cUSUARIOS.MODIFICAR_USUARIO(oUSUARIO);
                ARMA_GRILLA("A");
                REGISTRO_AUDITORIA_USUARIO(oUSUARIO, "R");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        class COMBOBOX_PROFESIONALES
        {
            public string CMB_TEXTO { get; set; }
            public int CMB_VALOR { get; set; }
            public COMBOBOX_PROFESIONALES(string T, int V)
            {
                CMB_TEXTO = T;
                CMB_VALOR = V;
            }
            public override string ToString()
            {
                return CMB_TEXTO;
            }
            public override int GetHashCode()
            {
                return CMB_VALOR;
            }
        }
        private void cmbGRUPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<COMBOBOX_PROFESIONALES> listaPROF = new List<COMBOBOX_PROFESIONALES>();
            if (cmbGRUPO.SelectedItem != null && cmbGRUPO.SelectedItem.ToString() == "PROFESIONAL")
            {
                var profesionales = (from p in cPROFESIONALES.OBTENER_PROFESIONALES() select p).ToList();
                listaPROF.Add(new COMBOBOX_PROFESIONALES("SELECCIONE...", -1));
                foreach (var prof in profesionales)
                {
                    listaPROF.Add(new COMBOBOX_PROFESIONALES(prof.NOMBRE + " " + prof.APELLIDO, prof.ID_PROFESIONAL));
                }
                cmbVincularProf.DataSource = listaPROF;
                cmbVincularProf.Enabled = true;
            }
            else
            {
                //cmbVincularProf.Items.Clear();
                cmbVincularProf.Enabled = false;
            }
        }
    }

}
