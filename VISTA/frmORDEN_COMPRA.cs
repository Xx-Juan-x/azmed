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
        string[] texto_cotizacion;
        

        public frmORDEN_COMPRA()
        {
            InitializeComponent();
            cSOLICITUDES_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            cCOTIZACIONES = CONTROLADORA.COTIZACIONES.OBTENER_INSTANCIA();
            cORDENES_COMPRAS = CONTROLADORA.ORDENES_DE_COMPRAS.OBTENER_INSTANCIA();
            cLISTA_ORDENES_COMPRAS = CONTROLADORA.LISTA_ORDENES_DE_COMPRAS.OBTENER_INSTANCIA();
            ARMA_COMBOBOX_SOLICITUD_PEDIDO();
            txtCOTIZACION_1.Enabled = false;
            txtCOTIZACION_2.Enabled = false;
            txtCOTIZACION_3.Enabled = false;
            txtCOTIZACION_4.Enabled = false;
            txtCOTIZACION_5.Enabled = false;
            txtCOTIZACION_6.Enabled = false;
            txtCOTIZACION_7.Enabled = false;
            txtCOTIZACION_8.Enabled = false;
            txtCOTIZACION_9.Enabled = false;
            txtCOTIZACION_10.Enabled = false;           
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
                TextBox tbx = this.Controls.Find("txtCOTIZACION_" + j, true).FirstOrDefault() as TextBox;
                if(tbx != null)
                {
                    tbx.Text = ""; 
                }
                TextBox tcx = this.Controls.Find("txtCANTIDAD_" + j, true).FirstOrDefault() as TextBox;
                if (tcx != null)
                {
                    tcx.Text = "";
                    tcx.Enabled = true;
                }
            }

            var LISTA_COTIZACIONES = (from a in cCOTIZACIONES.OBTENER_COTIZACIONES()
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

            for (int j = i; j < 11; j++)
            {
                TextBox tbx = this.Controls.Find("txtCOTIZACION_" + j, true).FirstOrDefault() as TextBox;
                TextBox tbc = this.Controls.Find("txtCANTIDAD_" + j, true).FirstOrDefault() as TextBox;
                if (tbx != null)
                {
                    tbx.Enabled = false;
                }
                if (tbc != null)
                {
                    tbc.Enabled = false;
                }
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
            oORDEN_COMPRA = new MODELO.ORDEN_COMPRA();
            oORDEN_COMPRA.PEDIDO = (MODELO.SOLICITUD_PEDIDO)cmbSOLICITUD_PEDIDO.SelectedItem;
            oORDEN_COMPRA.FECHA = DateTime.Now;
            cORDENES_COMPRAS.AGREGAR_ORDEN_COMPRA(oORDEN_COMPRA);

            var COMPRAS = (from a in cORDENES_COMPRAS.OBTENER_ORDENES_COMPRAS()
                           select a).ToList();

            MODELO.ORDEN_COMPRA ULTIMA_COMPRA = COMPRAS.Last();

            for (int c = 1; c < 11; c++)
            {
                bool cantidad = false;
                bool cotizacion = false;

                TextBox tbx = this.Controls.Find("txtCOTIZACION_" + c, true).FirstOrDefault() as TextBox;
                if (tbx.Text.Length > 0)
                {
                    texto_cotizacion = tbx.Text.Split('-');
                    cotizacion = true;
                }
                TextBox tcx = this.Controls.Find("txtCANTIDAD_" + c, true).FirstOrDefault() as TextBox;
                if (tcx.Text.Length > 0)
                {
                    cantidad = true;
                }

                if (cotizacion == true && cantidad == true)
                {
                    oLISTA_COMPRA = new MODELO.LISTA_COMPRA();
                    oLISTA_COMPRA.CANTIDAD = Convert.ToInt32(tcx.Text);
                    oCOTIZACION = new MODELO.COTIZACION();
                    oCOTIZACION.ID_COTIZACION = Convert.ToInt32(texto_cotizacion[0]);

                    var COTIZACION = (from a in cCOTIZACIONES.OBTENER_COTIZACIONES()
                                      where a.ID_COTIZACION == Convert.ToInt32(texto_cotizacion[0])
                                      select a).ToList();

                    oLISTA_COMPRA.COTIZACION = (MODELO.COTIZACION)COTIZACION[0];
                    oLISTA_COMPRA.PRECIO = Convert.ToInt32(texto_cotizacion[2]);
                    oLISTA_COMPRA.COMPRA = ULTIMA_COMPRA;
                    cLISTA_ORDENES_COMPRAS.AGREGAR_LISTA_ORDEN_COMPRA(oLISTA_COMPRA);
                }
            }
            //PONER MENSAJE SIN QUE SE REPITA
            MessageBox.Show("Su Orden de compra se concretó con éxito");
        }
    }
}
