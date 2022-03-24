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
    public partial class frmPROVEEDOR : Form
    {
        //PATRON SINGLETON
        private static frmPROVEEDOR instancia;

        public static frmPROVEEDOR OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmPROVEEDOR();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmPROVEEDOR();
            }
            return instancia;
        }

        private CONTROLADORA.PROVEEDORES cPROVEEDORES;
        private MODELO.PROVEEDOR oPROVEEDOR;        
        string ACCION;

        public frmPROVEEDOR()
        {
            InitializeComponent();
            cPROVEEDORES = CONTROLADORA.PROVEEDORES.OBTENER_INSTANCIA();
            ARMA_GRILLA();
            MODO_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_PROVEEDORES.DataSource = null;
            dgvLISTA_PROVEEDORES.DataSource = cPROVEEDORES.OBTENER_PROVEEDORES();
        }

        private void MODO_GRILLA()
        {
            gbLISTA_PROVEEDORES.Enabled = true;
            gbDATOS_PROVEEDOR.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_PROVEEDORES.Enabled = false;
            gbDATOS_PROVEEDOR.Enabled = true;

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
            oPROVEEDOR = new MODELO.PROVEEDOR();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del proveedor de forma correcta", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAPELLIDO.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del proveedor de forma correcta", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int64 CUIL;
            if (!Int64.TryParse(txtCUIL.Text, out CUIL))
            {
                MessageBox.Show("Debe ingresar el cuil del proveedor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int64 CONTACTO;
            if (!Int64.TryParse(txtCONTACTO.Text, out CONTACTO))
            {
                MessageBox.Show("Debe ingresar un contacto de forma correcta para poder registrar al proveedor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            oPROVEEDOR.NOMBRE = txtNOMBRE.Text.ToUpper();
            oPROVEEDOR.APELLIDO = txtAPELLIDO.Text.ToUpper();
            oPROVEEDOR.CUIL = CUIL;
            oPROVEEDOR.CONTACTO = CONTACTO;

            if (ACCION == "A")
            {
                cPROVEEDORES.AGREGAR_PROVEEDOR(oPROVEEDOR);
            }
            else if (ACCION == "M")
            {
                cPROVEEDORES.MODIFICAR_PROVEEDOR(oPROVEEDOR);
            }

            txtNOMBRE.Clear();
            txtAPELLIDO.Clear();
            txtCUIL.Clear();
            txtCONTACTO.Clear();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPROVEEDOR = (MODELO.PROVEEDOR)dgvLISTA_PROVEEDORES.CurrentRow.DataBoundItem;

            ACCION = "M";

            txtNOMBRE.Text = oPROVEEDOR.NOMBRE.ToUpper();
            txtAPELLIDO.Text = oPROVEEDOR.APELLIDO.ToUpper();
            txtCUIL.Text = oPROVEEDOR.CUIL.ToString();
            txtCONTACTO.Text = oPROVEEDOR.CONTACTO.ToString();

            MODO_DATOS();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPROVEEDOR = (MODELO.PROVEEDOR)dgvLISTA_PROVEEDORES.CurrentRow.DataBoundItem;

            ACCION = "C";

            txtNOMBRE.Text = oPROVEEDOR.NOMBRE.ToUpper();
            txtAPELLIDO.Text = oPROVEEDOR.APELLIDO.ToUpper();
            txtCUIL.Text = oPROVEEDOR.CUIL.ToString();
            txtCONTACTO.Text = oPROVEEDOR.CONTACTO.ToString();

            MODO_DATOS();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPROVEEDOR = (MODELO.PROVEEDOR)dgvLISTA_PROVEEDORES.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar el proveedor " + oPROVEEDOR.NOMBRE + " " + oPROVEEDOR.APELLIDO + " de la lista de proveedores?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cPROVEEDORES.ELIMINAR_PROVEEDOR(oPROVEEDOR);
                ARMA_GRILLA();
            }


        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            txtAPELLIDO.Clear();
            txtCUIL.Clear();
            txtCONTACTO.Clear();
            MODO_GRILLA();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAPELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCUIL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCONTACTO_KeyPress(object sender, KeyPressEventArgs e)
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
