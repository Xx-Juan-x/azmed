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
    public partial class frmORDEN_COMPRA : Form
    {
        private static frmORDEN_COMPRA instancia;

        public static frmORDEN_COMPRA OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmORDEN_COMPRA();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmORDEN_COMPRA();
            }
            return instancia;
        }

        private CONTROLADORA.SOLICITUDES_DE_PEDIDOS cSOLICITUDES_PEDIDOS;
        private MODELO.SOLICITUD_PEDIDO oSOLICITUD_PEDIDO;
        private CONTROLADORA.COTIZACIONES cCOTIZACIONES;
        private CONTROLADORA.ORDENES_DE_COMPRAS cORDENES_COMPRAS;
        private MODELO.ORDEN_COMPRA oORDEN_COMPRA;
        private MODELO.LISTA_COMPRA oLISTA_COMPRA;
        private CONTROLADORA.LISTA_ORDENES_DE_COMPRAS cLISTA_ORDENES_COMPRAS;
        private MODELO.COTIZACION oCOTIZACION;
        private CONTROLADORA.LISTA_COTIZACION cLISTA_COTIZACION;
        private CONTROLADORA.LISTA_DE_PEDIDOS cLISTA_PEDIDO;
        string[] texto_cotizacion;
        

        public frmORDEN_COMPRA()
        {

            InitializeComponent();

            for (int j = 1; j < 11; j++)
            {
                TextBox tbx = this.Controls.Find("txtPrecio" + j, true).FirstOrDefault() as TextBox;
                if (tbx != null)
                {
                    tbx.Text = "";
                    tbx.Enabled = false;
                    tbx.BackColor = System.Drawing.Color.Gray;
                }
                TextBox tcx = this.Controls.Find("txtCantidad" + j, true).FirstOrDefault() as TextBox;
                if (tcx != null)
                {
                    tcx.Text = "";
                    tcx.Enabled = false;
                    tcx.BackColor = System.Drawing.Color.Gray;
                }
                ComboBox cmbC = this.Controls.Find("cmbCotizacion_" + j, true).FirstOrDefault() as ComboBox;
                if (cmbC != null)
                {
                    cmbC.Enabled = false;
                    cmbC.BackColor = System.Drawing.Color.Gray;
                    cmbC.DataSource = null;
                }
            }
            cSOLICITUDES_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            cCOTIZACIONES = CONTROLADORA.COTIZACIONES.OBTENER_INSTANCIA();
            cORDENES_COMPRAS = CONTROLADORA.ORDENES_DE_COMPRAS.OBTENER_INSTANCIA();
            cLISTA_ORDENES_COMPRAS = CONTROLADORA.LISTA_ORDENES_DE_COMPRAS.OBTENER_INSTANCIA();
            cLISTA_COTIZACION = CONTROLADORA.LISTA_COTIZACION.OBTENER_INSTANCIA();
            cLISTA_PEDIDO = CONTROLADORA.LISTA_DE_PEDIDOS.OBTENER_INSTANCIA();
            ARMA_COMBOBOX_SOLICITUD_PEDIDO();

        }

        private void ARMA_COMBOBOX_SOLICITUD_PEDIDO()
        {
            cmbSOLICITUD_PEDIDO.DataSource = null;
            cmbSOLICITUD_PEDIDO.DataSource = cSOLICITUDES_PEDIDOS.OBTENER_SOLICITUDES_PEDIDOS();
        }

        private void ARMA_GRILLA_COTIZACION(int ID_SOLICITUD_PEDIDO)
        {
            for (int j = 1; j < 11; j++)
            {
                TextBox tbx = this.Controls.Find("txtPrecio" + j, true).FirstOrDefault() as TextBox;
                if (tbx != null)
                {
                    tbx.Text = "";
                    tbx.Enabled = false;
                    tbx.BackColor = System.Drawing.Color.Gray;
                }
                TextBox tcx = this.Controls.Find("txtCantidad" + j, true).FirstOrDefault() as TextBox;
                if (tcx != null)
                {
                    tcx.Text = "";
                    tcx.Enabled = false;
                    tcx.BackColor = System.Drawing.Color.Gray;
                }
                ComboBox cmbC = this.Controls.Find("cmbCotizacion_" + j, true).FirstOrDefault() as ComboBox;
                if (cmbC != null)
                {
                    cmbC.Enabled = false;
                    cmbC.BackColor = System.Drawing.Color.Gray;
                    cmbC.DataSource = null;
                }
            }
            var LISTA_COTIZACIONES = 
                (from a in cCOTIZACIONES.OBTENER_COTIZACIONES()
                where a.PEDIDO.ID_SOLICITUD_PEDIDO == ID_SOLICITUD_PEDIDO 
                select a).ToList();

            dgvLISTA_COTIZACIONES.DataSource = null;
            dgvLISTA_COTIZACIONES.DataSource = LISTA_COTIZACIONES;

            int i = 1;
            foreach (var item in LISTA_COTIZACIONES)
            {
                TextBox tbx = this.Controls.Find("txtCOTIZACION_" + i, true).FirstOrDefault() as TextBox;
                if (tbx != null)
                {
                    //tbx.Text = item.ID_COTIZACION + "-" + item.NOMBRE + "-" + item.PRECIO; ACA
                }
                i++;
            }
            i = 0;
            var LISTA_SOLICITUD = (from l in cLISTA_PEDIDO.OBTENER_LISTA_PEDIDOS() where l.PEDIDO.ID_SOLICITUD_PEDIDO == ID_SOLICITUD_PEDIDO select l ).ToList();
            foreach(var lista_pedidos in LISTA_SOLICITUD) {
                var LISTA_COTIZACION = (from lc in cLISTA_COTIZACION.OBTENER_LISTA_COTIZACIONES() where lc.COTIZACION.PEDIDO.ID_SOLICITUD_PEDIDO == ID_SOLICITUD_PEDIDO && lc.MATERIAL.ID_MATERIAL == lista_pedidos.INSUMO.ID_MATERIAL select lc).ToList();

                ComboBox cmbc = this.Controls.Find("cmbCotizacion_" + (i+ 1), true).FirstOrDefault() as ComboBox;
                TextBox tbp = this.Controls.Find("txtPrecio" + (i + 1), true).FirstOrDefault() as TextBox;
                TextBox tbc = this.Controls.Find("txtCantidad" + (i + 1), true).FirstOrDefault() as TextBox;
                cmbc.DataSource = null;
                cmbc.ValueMember = "ID_PROVEEDOR";
                cmbc.DisplayMember = "NOMBRE";
                List<ComboboxItem> LISTA_CMB_COTIZACION= new List<ComboboxItem>();
                ComboboxItem opcion = new ComboboxItem();
                opcion.Text = "Elegir cotizacion";
                opcion.Value = -1;
                LISTA_CMB_COTIZACION.Add(opcion);
                foreach (var itemLC in LISTA_COTIZACION)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = itemLC.COTIZACION.PROVEEDOR.NOMBRE+" "+itemLC.COTIZACION.PROVEEDOR.APELLIDO +" : $"+itemLC.PRECIO;
                    item.Value = itemLC.ID_LISTA_COTIZACION;
                    LISTA_CMB_COTIZACION.Add(item);
                }
                cmbc.DataSource = LISTA_CMB_COTIZACION;
                cmbc.Enabled = true;
                tbc.Enabled = true;
                cmbc.BackColor = System.Drawing.Color.White;
                tbp.BackColor = System.Drawing.Color.White;
                tbc.BackColor = System.Drawing.Color.White;

                i++;
                
            }
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
        private void cmbSOLICITUD_PEDIDO_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ID_PEDIDO = (MODELO.SOLICITUD_PEDIDO)cmbSOLICITUD_PEDIDO.SelectedValue;
            var LISTA_COTIZACION = ID_PEDIDO.ID_SOLICITUD_PEDIDO;
            ARMA_GRILLA_COTIZACION(LISTA_COTIZACION); 
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnENVIAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES

            double PRECIO_UNITARIO;
            if (txtPrecio1.Enabled == true && !double.TryParse(txtPrecio1.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio2.Enabled == true && !double.TryParse(txtPrecio2.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio3.Enabled == true && !double.TryParse(txtPrecio3.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio4.Enabled == true && !double.TryParse(txtPrecio4.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio5.Enabled == true && !double.TryParse(txtPrecio5.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio6.Enabled == true && !double.TryParse(txtPrecio6.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio7.Enabled == true && !double.TryParse(txtPrecio7.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio8.Enabled == true && !double.TryParse(txtPrecio8.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio9.Enabled == true && !double.TryParse(txtPrecio9.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio10.Enabled == true && !double.TryParse(txtPrecio10.Text, out PRECIO_UNITARIO))
            {
                MessageBox.Show("Debe ingresar un precio unitario al material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double CANTIDAD_MATERIAL;
            if (txtCantidad1.Enabled == true && !double.TryParse(txtCantidad1.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad2.Enabled == true && !double.TryParse(txtCantidad2.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad3.Enabled == true && !double.TryParse(txtCantidad3.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad4.Enabled == true && !double.TryParse(txtCantidad4.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad5.Enabled == true && !double.TryParse(txtCantidad5.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad6.Enabled == true && !double.TryParse(txtCantidad6.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad7.Enabled == true && !double.TryParse(txtCantidad7.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad8.Enabled == true && !double.TryParse(txtCantidad8.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad9.Enabled == true && !double.TryParse(txtCantidad9.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad10.Enabled == true && !double.TryParse(txtCantidad10.Text, out CANTIDAD_MATERIAL))
            {
                MessageBox.Show("Debe ingresar una cantidad a ordenar del material para enviar la orden de compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            oORDEN_COMPRA = new MODELO.ORDEN_COMPRA();
            oORDEN_COMPRA.PEDIDO = (MODELO.SOLICITUD_PEDIDO)cmbSOLICITUD_PEDIDO.SelectedItem;
            oORDEN_COMPRA.FECHA = DateTime.Now;
            var ID_PEDIDO = (MODELO.SOLICITUD_PEDIDO)cmbSOLICITUD_PEDIDO.SelectedValue;
            var EXISTE_COMPRA = (from a in cORDENES_COMPRAS.OBTENER_ORDENES_COMPRAS() where a.PEDIDO.ID_SOLICITUD_PEDIDO == ID_PEDIDO.ID_SOLICITUD_PEDIDO select a).ToList();
            if (EXISTE_COMPRA.Count == 0)
            {
                cORDENES_COMPRAS.AGREGAR_ORDEN_COMPRA(oORDEN_COMPRA);

                var COMPRAS = (from a in cORDENES_COMPRAS.OBTENER_ORDENES_COMPRAS() select a).ToList();

                MODELO.ORDEN_COMPRA ULTIMA_COMPRA = COMPRAS.Last();

                for (int c = 1; c < 11; c++)
                {
                    bool cantidad = false;
                    bool cotizacion = false;
                    bool precio = false;

                    ComboBox cmbc = this.Controls.Find("cmbCotizacion_" + c, true).FirstOrDefault() as ComboBox;
                    if (cmbc.Text.Length > 0)
                    {
                        texto_cotizacion = cmbc.Text.Split('-');
                        cotizacion = true;
                    }
                    TextBox tbc = this.Controls.Find("txtCantidad" + c, true).FirstOrDefault() as TextBox;
                    if (tbc.Text.Length > 0)
                    {
                        cantidad = true;
                    }
                    TextBox tbp = this.Controls.Find("txtPrecio" + c, true).FirstOrDefault() as TextBox;
                    if (tbp.Text.Length > 0)
                    {
                        precio = true;
                    }

                    if (cotizacion == true && cantidad == true)
                    {
                        oLISTA_COMPRA = new MODELO.LISTA_COMPRA();
                        oLISTA_COMPRA.CANTIDAD = Convert.ToInt32(tbc.Text);
                        ComboboxItem proveedor_seleccionado = (ComboboxItem)cmbc.SelectedItem;
                        var l_cotizacion = (from a in cLISTA_COTIZACION.OBTENER_LISTA_COTIZACIONES()
                                            where a.ID_LISTA_COTIZACION == Convert.ToInt32(proveedor_seleccionado.Value)
                                            select a).ToList();

                        oLISTA_COMPRA.LISTA_COTIZACION = (MODELO.LISTA_COTIZACION)l_cotizacion[0];
                        oLISTA_COMPRA.PRECIO = Convert.ToInt32(tbp.Text);
                        oLISTA_COMPRA.COMPRA = ULTIMA_COMPRA;
                        cLISTA_ORDENES_COMPRAS.AGREGAR_LISTA_ORDEN_COMPRA(oLISTA_COMPRA);
                    }
                }
                MessageBox.Show("Su Orden de compra fue AGREGADA con exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (EXISTE_COMPRA.Count > 0)
            {
                
                var l_orden_compra = (from a in cLISTA_ORDENES_COMPRAS.OBTENER_LISTA_COMPRAS()
                                    where a.COMPRA.ID_ORDEN_COMPRA == Convert.ToInt32(EXISTE_COMPRA[0].ID_ORDEN_COMPRA)
                                    select a).ToList();
                foreach (var item in l_orden_compra)
                {
                    cLISTA_ORDENES_COMPRAS.ELIMINAR_LISTA_ORDEN_COMPRA(item);
                }
                for (int c = 1; c < 11; c++)
                {
                    bool cantidad = false;
                    bool cotizacion = false;
                    bool precio = false;

                    ComboBox cmbc = this.Controls.Find("cmbCotizacion_" + c, true).FirstOrDefault() as ComboBox;
                    if (cmbc.Text.Length > 0)
                    {
                        texto_cotizacion = cmbc.Text.Split('-');
                        cotizacion = true;
                    }
                    TextBox tbc = this.Controls.Find("txtCantidad" + c, true).FirstOrDefault() as TextBox;
                    if (tbc.Text.Length > 0)
                    {
                        cantidad = true;
                    }
                    TextBox tbp = this.Controls.Find("txtPrecio" + c, true).FirstOrDefault() as TextBox;
                    if (tbp.Text.Length > 0)
                    {
                        precio = true;
                    }
                    if (cotizacion == true && cantidad == true)
                    {
                        oLISTA_COMPRA = new MODELO.LISTA_COMPRA();
                        oLISTA_COMPRA.CANTIDAD = Convert.ToInt32(tbc.Text);
                        ComboboxItem proveedor_seleccionado = (ComboboxItem)cmbc.SelectedItem;
                        var l_cotizacion = (from a in cLISTA_COTIZACION.OBTENER_LISTA_COTIZACIONES()
                                            where a.ID_LISTA_COTIZACION == Convert.ToInt32(proveedor_seleccionado.Value)
                                            select a).ToList();

                        oLISTA_COMPRA.LISTA_COTIZACION = (MODELO.LISTA_COTIZACION)l_cotizacion[0];
                        oLISTA_COMPRA.PRECIO = Convert.ToInt32(tbp.Text);
                        oLISTA_COMPRA.COMPRA = EXISTE_COMPRA[0];
                        cLISTA_ORDENES_COMPRAS.AGREGAR_LISTA_ORDEN_COMPRA(oLISTA_COMPRA);
                    }
                }
                MessageBox.Show("Su Orden de compra fue EDITADA con exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }



        private void cmbSeleccionado_mostrarPrecio(object sender, EventArgs e)
        {

            ComboBox cotizacion_cmb = (ComboBox)sender;
            string[] i = cotizacion_cmb.Name.Split('_');
            ComboboxItem cotizacion_seleccionado = cotizacion_cmb.SelectedItem as ComboboxItem;
            if (cotizacion_seleccionado != null && cotizacion_seleccionado.Text != "Elegir cotizacion")
            {
                string[] precio = cotizacion_seleccionado.Text.Split('$');
                TextBox textPrecio = this.Controls.Find("txtPrecio" + i[1], true).FirstOrDefault() as TextBox;
                textPrecio.Text = precio[1].Split('.')[0];
            }

        }

        private void txtPrecio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio5_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio6_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio7_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio8_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio9_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio10_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad5_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad6_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad7_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad8_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad9_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad10_KeyPress(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex("^[0-9,]*$");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
