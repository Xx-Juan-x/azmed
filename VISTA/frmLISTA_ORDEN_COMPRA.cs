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
    public partial class frmLISTA_ORDEN_COMPRA : Form
    {
        private static frmLISTA_ORDEN_COMPRA instancia;

        public static frmLISTA_ORDEN_COMPRA OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmLISTA_ORDEN_COMPRA();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmLISTA_ORDEN_COMPRA();
            }
            return instancia;
        }

        private CONTROLADORA.LISTA_ORDENES_DE_COMPRAS cLISTA_ORDENES_COMPRAS;

        public frmLISTA_ORDEN_COMPRA()
        {
            InitializeComponent();

            cLISTA_ORDENES_COMPRAS = CONTROLADORA.LISTA_ORDENES_DE_COMPRAS.OBTENER_INSTANCIA();         
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            try
            {
                var LISTA_ORDEN_COMPRA = (from a in cLISTA_ORDENES_COMPRAS.OBTENER_LISTA_COMPRAS()
                                          select new
                                          {
                                              ID_LISTA_COMPRA = a.ID_LISTA_COMPRA,
                                              CANTIDAD = a.CANTIDAD,
                                              COMPRA = a.COMPRA.PEDIDO.DESCRIPCION,
                                              FECHA_DEL_PEDIDO = a.COMPRA.PEDIDO.FECHA,
                                              PRECIO = a.PRECIO,
                                              //ESTOS DOS NO ME LOS TOMA Y NO SE PORQUE, EL DE COMPRA SI
                                              PROVEEDOR = a.LISTA_COTIZACION?.COTIZACION?.PROVEEDOR?.NOMBRE + a.LISTA_COTIZACION?.COTIZACION?.PROVEEDOR?.APELLIDO,
                                              MATERIAL = a.LISTA_COTIZACION?.MATERIAL?.NOMBRE,
                                          }).ToList();

                dgvLISTA_ORDENES_COMPRA.DataSource = null;
                dgvLISTA_ORDENES_COMPRA.DataSource = LISTA_ORDEN_COMPRA;
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y muestra un mensaje de error o registra el error en un archivo de registro.
                MessageBox.Show("ERROR AL CARGAR LOS DATOS: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
