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
    public partial class frmOBRA_SOCIAL : Form
    {
        //PATRON SINGLETON
        private static frmOBRA_SOCIAL instancia;

        public static frmOBRA_SOCIAL OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmOBRA_SOCIAL();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmOBRA_SOCIAL();
            }
            return instancia;
        }

        private CONTROLADORA.OBRAS_SOCIALES cOBRAS_SOCIALES;
        private MODELO.OBRA_SOCIAL oOBRA_SOCIAL;
        private CONTROLADORA.PLANES cPLANES;
        private string OBRA_SOCIAL;
        string ACCION;

        public frmOBRA_SOCIAL()
        {
            InitializeComponent();
            cOBRAS_SOCIALES = CONTROLADORA.OBRAS_SOCIALES.OBTENER_INSTANCIA();
            cPLANES = CONTROLADORA.PLANES.OBTENER_INSTANCIA();
            ARMA_GRILLA();
            MODO_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_OBRAS_SOCIALES.DataSource = null;
            dgvLISTA_OBRAS_SOCIALES.DataSource = cOBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES();
        }

        private void MODO_GRILLA()
        {
            gbLISTA_OBRAS_SOCIALES.Enabled = true;
            gbDATOS_OBRA_SOCIAL.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_OBRAS_SOCIALES.Enabled = false;
            gbDATOS_OBRA_SOCIAL.Enabled = true;

            if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            }
            else
            {
                btnGUARDAR.Enabled = true;
            }
        }

        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            oOBRA_SOCIAL = new MODELO.OBRA_SOCIAL();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES

            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la obra social para poder agregarla", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int64 CUIL;
            if (!Int64.TryParse(txtCUIL.Text, out CUIL))
            {
                MessageBox.Show("Debe ingresar el cuil de la obra social", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int64 CONTACTO;
            if (!Int64.TryParse(txtCONTACTO.Text, out CONTACTO))
            {
                MessageBox.Show("Debe ingresar un contacto de forma correcta para poder registrar la obra social", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCUIL.TextLength != 11)
            {
                MessageBox.Show("El Cuil es incorrecto", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCONTACTO.TextLength <= 5)
            {
                MessageBox.Show("El contacto es demasiado corto", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtCONTACTO.TextLength > 14)
            {
                MessageBox.Show("El contacto es demasiado largo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            // ASIGNO MI TEXTBOX CON MI PROPIEDAD
            oOBRA_SOCIAL.NOMBRE = txtNOMBRE.Text.ToUpper(); // Uso la funcion ToUapper para escribir el nombre en mayúscula
            oOBRA_SOCIAL.CUIL = CUIL;
            oOBRA_SOCIAL.CONTACTO = CONTACTO;

            if (ACCION == "A")
            {
                cOBRAS_SOCIALES.AGREGAR_OBRA_SOCIAL(oOBRA_SOCIAL);
            }
            else
            {
                cOBRAS_SOCIALES.MODIFICAR_OBRA_SOCIAL(oOBRA_SOCIAL);
            }

            // LIMPIO LAS TEXTBOX
            txtNOMBRE.Clear();
            txtCUIL.Clear();
            txtCONTACTO.Clear();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void btnMODIFICAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_OBRAS_SOCIALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una obra social de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oOBRA_SOCIAL = (MODELO.OBRA_SOCIAL)dgvLISTA_OBRAS_SOCIALES.CurrentRow.DataBoundItem;

            ACCION = "M";

            txtNOMBRE.Text = oOBRA_SOCIAL.NOMBRE.ToUpper();
            txtCUIL.Text = oOBRA_SOCIAL.CUIL.ToString();
            txtCONTACTO.Text = oOBRA_SOCIAL.CONTACTO.ToString();

            MODO_DATOS();
        }

        private void btnCONSULTAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_OBRAS_SOCIALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una obra social de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oOBRA_SOCIAL = (MODELO.OBRA_SOCIAL)dgvLISTA_OBRAS_SOCIALES.CurrentRow.DataBoundItem;

            ACCION = "C";

            txtNOMBRE.Text = oOBRA_SOCIAL.NOMBRE.ToUpper();
            txtCUIL.Text = oOBRA_SOCIAL.CUIL.ToString();
            txtCONTACTO.Text = oOBRA_SOCIAL.CONTACTO.ToString();

            MODO_DATOS();
        }

        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_OBRAS_SOCIALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una obra social de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oOBRA_SOCIAL = (MODELO.OBRA_SOCIAL)dgvLISTA_OBRAS_SOCIALES.CurrentRow.DataBoundItem;

            OBRA_SOCIAL = "";
            foreach (DataGridViewRow row in dgvLISTA_OBRAS_SOCIALES.SelectedRows)
            {
                OBRA_SOCIAL = (string)row.Cells["NOMBRE"].Value;
            }

            if (OBRA_SOCIAL == "")
            {
                MessageBox.Show("Debe seleccionar la fila entera", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var LISTA_PLANES = (from a in cPLANES.OBTENER_PLANES()
                                    where a.OBRA_SOCIAL.NOMBRE == OBRA_SOCIAL
                                    select a).ToList();
                if (LISTA_PLANES.Count == 0)
                {
                    DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar la obra social " + oOBRA_SOCIAL.NOMBRE + " de la lista de obras sociales?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (RESPUESTA == DialogResult.Yes)
                    {
                        cOBRAS_SOCIALES.ELIMINAR_OBRA_SOCIAL(oOBRA_SOCIAL);
                        ARMA_GRILLA();
                    }
                }
                else
                {
                    MessageBox.Show("La Obra Social ya cuenta con uno o mas planes, borre los planes vinculados a esta obra social antes de eliminarla", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            txtCUIL.Clear();
            txtCONTACTO.Clear();
            MODO_GRILLA();
        }

        private void btnCERRAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
        private void txtCUIL_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCONTACTO_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }       
    }
}
