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
    public partial class frmCOTIZACION : Form
    {
        private static frmCOTIZACION instancia;

        public static frmCOTIZACION OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmCOTIZACION();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmCOTIZACION();
            }
            return instancia;
        }

        private CONTROLADORA.COTIZACIONES cCOTIZACIONES;
        private MODELO.COTIZACION oCONTIZACION;
        private CONTROLADORA.PROVEEDORES cPROVEEDORES;
        private CONTROLADORA.SOLICITUDES_DE_PEDIDOS cSOLICITUDES_PEDIDOS;
        string ACCION;

        public frmCOTIZACION()
        {
            InitializeComponent();
            cCOTIZACIONES = CONTROLADORA.COTIZACIONES.OBTENER_INSTANCIA();
            cPROVEEDORES = CONTROLADORA.PROVEEDORES.OBTENER_INSTANCIA();
            cSOLICITUDES_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            ARMA_COMBOBOX_PROVEEDOR();
            ARMA_COMBOBOX_SOLICITUD_PEDIDO();

        }

        private void ARMA_COMBOBOX_PROVEEDOR()
        {
            cmbPROVEEDOR.DataSource = null;
            cmbPROVEEDOR.DataSource = cPROVEEDORES.OBTENER_PROVEEDORES();
        }

        private void ARMA_COMBOBOX_SOLICITUD_PEDIDO()
        {
            cmbSOLICITUD_PEDIDO.DataSource = null;
            cmbSOLICITUD_PEDIDO.DataSource = cSOLICITUDES_PEDIDOS.OBTENER_SOLICITUDES_PEDIDOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nombre a la cotizacion", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPROVEEDOR.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir un proveedor disponible para poder cotizar el material", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbSOLICITUD_PEDIDO.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir una solicitud para poder cotizar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double PRECIO_UNITARIO;
            if (!double.TryParse(txtPRECIO.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material que se va a cotizar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMOTIVO.Text))
            {
                MessageBox.Show("Debe ingresar un motivo de porqué ganó tal proveedor con tal material", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            oCONTIZACION = new MODELO.COTIZACION();
            ACCION = "A";

            oCONTIZACION.NOMBRE = txtNOMBRE.Text.ToUpper();
            oCONTIZACION.FECHA = DateTime.Now;
            oCONTIZACION.PROVEEDOR = (MODELO.PROVEEDOR)cmbPROVEEDOR.SelectedItem;          
            oCONTIZACION.PRECIO = PRECIO_UNITARIO;
            oCONTIZACION.MOTIVO = txtMOTIVO.Text.ToUpper();

            if (ACCION == "A")
            {
                DialogResult RESPUESTA = MessageBox.Show("¿Está seguro que desea cotizar el pedido?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (RESPUESTA == DialogResult.Yes)
                {
                    cCOTIZACIONES.AGREGAR_COTIZACION(oCONTIZACION);
                    txtNOMBRE.Clear();
                    ARMA_COMBOBOX_PROVEEDOR();
                    ARMA_COMBOBOX_SOLICITUD_PEDIDO();
                    txtPRECIO.Clear();
                    txtMOTIVO.Clear();
                }           
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
