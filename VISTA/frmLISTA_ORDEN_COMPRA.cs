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
        private CONTROLADORA.ORDENES_DE_COMPRAS cORDENES_COMPRAS;
        private CONTROLADORA.LISTA_COTIZACION cLISTA_COTIZACION;
        private CONTROLADORA.PROVEEDORES cPROVEEDORES;
        private CONTROLADORA.MATERIALES cMATERIALES;

        public frmLISTA_ORDEN_COMPRA()
        {
            InitializeComponent();
            
            cLISTA_ORDENES_COMPRAS = CONTROLADORA.LISTA_ORDENES_DE_COMPRAS.OBTENER_INSTANCIA();         
            cORDENES_COMPRAS = CONTROLADORA.ORDENES_DE_COMPRAS.OBTENER_INSTANCIA();
            cLISTA_COTIZACION = CONTROLADORA.LISTA_COTIZACION.OBTENER_INSTANCIA();
            cMATERIALES = CONTROLADORA.MATERIALES.OBTENER_INSTANCIA();
            cPROVEEDORES = CONTROLADORA.PROVEEDORES.OBTENER_INSTANCIA();

            var ORDENES_COMPRAS = (from a in cORDENES_COMPRAS.OBTENER_ORDENES_COMPRAS() select a).ToList();
            List<ComboboxItem> todas_ordenes = new List<ComboboxItem>(); 
            foreach (var item in ORDENES_COMPRAS)
            {
                ComboboxItem combo = new ComboboxItem();
                combo.Text = item.PEDIDO.DESCRIPCION;
                combo.Value = item.ID_ORDEN_COMPRA;
                todas_ordenes.Add(combo);
            }
            cmbOrden.DataSource = todas_ordenes;
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void ARMA_GRILLA()
        {
            try
            {
                ComboboxItem orden_seleccionado = (ComboboxItem)cmbOrden.SelectedItem;
                var LISTA_ORDEN_COMPRA = (from a in cLISTA_ORDENES_COMPRAS.OBTENER_LISTA_COMPRAS()
                                          join lc in cLISTA_COTIZACION.OBTENER_LISTA_COTIZACIONES() on a.LISTA_COTIZACION.ID_LISTA_COTIZACION equals lc.ID_LISTA_COTIZACION
                                          join p in cPROVEEDORES.OBTENER_PROVEEDORES() on lc.COTIZACION.PROVEEDOR.ID_PROVEEDOR equals p.ID_PROVEEDOR
                                          
                                          where a.COMPRA.ID_ORDEN_COMPRA == Convert.ToInt32(orden_seleccionado.Value)
                                          select new
                                          {
                                              ID_LISTA_COMPRA = a.ID_LISTA_COMPRA,
                                              CANTIDAD = a.CANTIDAD,
                                              FECHA_DEL_PEDIDO = a.COMPRA.PEDIDO.FECHA,
                                              PRECIO = "$ "+a.PRECIO,
                                              //ESTOS DOS NO ME LOS TOMA Y NO SE PORQUE, EL DE COMPRA SI
                                              PROVEEDOR = lc.COTIZACION.PROVEEDOR.NOMBRE + " " + lc.COTIZACION.PROVEEDOR.APELLIDO,
                                              MATERIAL = lc.MATERIAL.NOMBRE,
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

        private void cmbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }
    }
}
