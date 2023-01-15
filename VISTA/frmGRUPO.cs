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
    public partial class frmGRUPO : Form
    {
        //PATRON SINGLETON
        private static frmGRUPO instancia;

        public static frmGRUPO OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmGRUPO();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmGRUPO();
            }
            return instancia;
        }

        private CONTROLADORA.GRUPOS cGRUPOS;
        private MODELO.GRUPO oGRUPO;
        string ACCION;

        public frmGRUPO()
        {
            InitializeComponent();
            cGRUPOS = CONTROLADORA.GRUPOS.OBTENER_INSTANCIA();
            ARMA_GRILLA();
            MODO_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_GRUPOS.DataSource = null;
            dgvLISTA_GRUPOS.DataSource = cGRUPOS.OBTENER_GRUPOS();
        }

        private void MODO_GRILLA()
        {
            gbLISTA_GRUPOS.Enabled = true;
            gbDATOS_GRUPO.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_GRUPOS.Enabled = false;
            gbDATOS_GRUPO.Enabled = true;

            if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            }
            else
            {
                btnGUARDAR.Enabled = true;
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            oGRUPO = new MODELO.GRUPO();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nombre al grupo para poder crear un grupo nuevo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            // ASIGNO MI TEXTBOX CON MI PROPIEDAD
            oGRUPO.NOMBRE = txtNOMBRE.Text.ToUpper();
            oGRUPO.ESTADO = "ACTIVO";

            if (ACCION == "A")
            {
                cGRUPOS.AGREGAR_GRUPO(oGRUPO);
            }
            else
            {
                cGRUPOS.MODIFICAR_GRUPO(oGRUPO);
            }

            // LIMPIO LA TEXTBOX
            txtNOMBRE.Clear();

            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_GRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oGRUPO = (MODELO.GRUPO)dgvLISTA_GRUPOS.CurrentRow.DataBoundItem;

            ACCION = "M";

            txtNOMBRE.Text = oGRUPO.NOMBRE.ToUpper();

            MODO_DATOS();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_GRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oGRUPO = (MODELO.GRUPO)dgvLISTA_GRUPOS.CurrentRow.DataBoundItem;

            ACCION = "C";

            txtNOMBRE.Text = oGRUPO.NOMBRE.ToUpper();

            MODO_DATOS();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_GRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oGRUPO = (MODELO.GRUPO)dgvLISTA_GRUPOS.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar el grupo " + oGRUPO.NOMBRE + " de la lista de grupos?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cGRUPOS.ELIMINAR_GRUPO(oGRUPO);
                ARMA_GRILLA();
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            MODO_GRILLA();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
