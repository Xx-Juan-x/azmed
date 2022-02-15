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
    public partial class frmUSUARIOS : Form
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

        public frmUSUARIOS()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            ARMA_GRILLA();
            MODO_GRILLA();
            
        }

        private CONTROLADORA.USUARIOS cUSUARIOS;
        private MODELO.USUARIO oUSUARIO;
        string ACCION;

        private void ARMA_GRILLA()
        {
            dgvLISTA_USUARIOS.DataSource = null;
            dgvLISTA_USUARIOS.DataSource = cUSUARIOS.OBTENER_USUARIOS();
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


        private void cmbROL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbROL.Items.Clear();
            cmbROL.Items.Add("PROFESIONAL");
            cmbROL.Items.Add("JEFE DE COMPRAS");
            cmbROL.Items.Add("ADMINISTRADOR");
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
                MessageBox.Show("Debe ingresar el nombre del usuario para poder crear un usuario");
                return;
            }
            
            if (string.IsNullOrEmpty(txtAPELLIDO.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del usuario para poder crear un usuario");
                return;
            }

            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("Debe ingresar el email del usuario para poder crear un usuario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPASSWORD.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña para crear el usuario", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCONFIRMAR_PASSWORD.Text))
            {
                MessageBox.Show("Debe confirmar la contraseña para poder ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            // ASIGNO MI TEXTBOX CON MI PROPIEDAD
            oUSUARIO.NOMBRE = txtNOMBRE.Text.ToUpper();// Uso la funcion ToUapper para escribir el nombre en mayúscula
            oUSUARIO.APELLIDO = txtAPELLIDO.Text.ToUpper();
            oUSUARIO.EMAIL = txtEMAIL.Text.ToUpper();
            oUSUARIO.CLAVE = txtPASSWORD.Text;
            oUSUARIO.TIPO = cmbROL.SelectedItem.ToString();

            if (txtPASSWORD.Text == txtCONFIRMAR_PASSWORD.Text)
            {
                if (ACCION == "A")
                {
                    cUSUARIOS.AGREGAR_USUARIO(oUSUARIO);
                }
                else
                {
                    cUSUARIOS.MODIFICAR_USUARIO(oUSUARIO);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar o modificar la misma contraseña");
                return;
            }

            // LIMPIO LA TEXTBOX
            txtNOMBRE.Clear();
            txtAPELLIDO.Clear();
            txtEMAIL.Clear();
            txtPASSWORD.Clear();
            txtCONFIRMAR_PASSWORD.Clear();

            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_USUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oUSUARIO = (MODELO.USUARIO)dgvLISTA_USUARIOS.CurrentRow.DataBoundItem;

            ACCION = "M";

            txtNOMBRE.Text = oUSUARIO.NOMBRE.ToUpper();
            txtAPELLIDO.Text = oUSUARIO.APELLIDO.ToUpper();
            txtEMAIL.Text = oUSUARIO.EMAIL.ToUpper();
            

            MODO_DATOS();
        }
    }
}
