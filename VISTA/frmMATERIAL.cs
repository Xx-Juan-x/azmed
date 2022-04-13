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
    public partial class frmMATERIAL : Form
    {
        //PATRON SINGLETON
        private static frmMATERIAL instancia;

        public static frmMATERIAL OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmMATERIAL();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmMATERIAL();
            }
            return instancia;
        }

        private CONTROLADORA.MATERIALES cMATERIALES;
        private MODELO.MATERIAL oMATERIAL;
        string ACCION;

        public frmMATERIAL()
        {
            InitializeComponent();
            cMATERIALES = CONTROLADORA.MATERIALES.OBTENER_INSTANCIA();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            var LISTA_MATERIALES = (from a in cMATERIALES.OBTENER_MATERIALES()
                                where a.NOMBRE != "SELECCIONE..."
                                select a).ToList();

            dgvLISTA_MATERIALES.DataSource = null;
            dgvLISTA_MATERIALES.DataSource = LISTA_MATERIALES;
        }

        private void MODO_GRILLA()
        {
            gbLISTA_MATERIALES.Enabled = true;
            gbDATOS_MATERIAL.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_MATERIALES.Enabled = false;
            gbDATOS_MATERIAL.Enabled = true;

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
            oMATERIAL = new MODELO.MATERIAL();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del insumo de forma correcta para poder registrar un nuevo material a la clinica", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDESCRIPCION.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion al insumo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int STOCK;
            if (!int.TryParse(txtSTOCK.Text, out STOCK))
            {
                MessageBox.Show("Debe ingresar la cantidad de insumos", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            oMATERIAL.NOMBRE = txtNOMBRE.Text.ToUpper();
            oMATERIAL.DESCRIPCION = txtDESCRIPCION.Text.ToUpper();
            oMATERIAL.STOCK = STOCK;

            if (ACCION == "A")
            {
                cMATERIALES.AGREGAR_MATERIAL(oMATERIAL);
            }
            else if (ACCION == "M")
            {
                cMATERIALES.MODIFICAR_MATERIAL(oMATERIAL);
            }

            txtNOMBRE.Clear();
            txtDESCRIPCION.Clear();
            txtSTOCK.Clear();
            MODO_GRILLA();
            ARMA_GRILLA();         
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_MATERIALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un insumo de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oMATERIAL = (MODELO.MATERIAL)dgvLISTA_MATERIALES.CurrentRow.DataBoundItem;

            ACCION = "M";

            txtNOMBRE.Text = oMATERIAL.NOMBRE.ToUpper();
            txtDESCRIPCION.Text = oMATERIAL.DESCRIPCION.ToUpper();
            txtSTOCK.Text = oMATERIAL.STOCK.ToString();
            MODO_DATOS();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_MATERIALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un insumo de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oMATERIAL = (MODELO.MATERIAL)dgvLISTA_MATERIALES.CurrentRow.DataBoundItem;

            ACCION = "C";

            txtNOMBRE.Text = oMATERIAL.NOMBRE.ToUpper();
            txtDESCRIPCION.Text = oMATERIAL.DESCRIPCION.ToUpper();
            txtSTOCK.Text = oMATERIAL.STOCK.ToString();
            MODO_DATOS();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_MATERIALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un insumo de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oMATERIAL = (MODELO.MATERIAL)dgvLISTA_MATERIALES.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar el insumo " + oMATERIAL.NOMBRE + " de la lista de insumos?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cMATERIALES.ELIMINAR_MATERIAL(oMATERIAL);
                ARMA_GRILLA();
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            txtDESCRIPCION.Clear();
            txtSTOCK.Clear();
            MODO_GRILLA();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSTOCK_KeyPress(object sender, KeyPressEventArgs e)
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
