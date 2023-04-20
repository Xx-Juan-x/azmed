using CONTROLADORA;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private CONTROLADORA.LISTA_DE_PEDIDOS cLISTA_PEDIDOS;
        private MODELO.LISTA_PEDIDO oLISTA_PEDIDO;
        string ACCION;

        public frmCOTIZACION()
        {
            InitializeComponent();
            cCOTIZACIONES = CONTROLADORA.COTIZACIONES.OBTENER_INSTANCIA();
            cPROVEEDORES = CONTROLADORA.PROVEEDORES.OBTENER_INSTANCIA();
            cSOLICITUDES_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            cLISTA_PEDIDOS = CONTROLADORA.LISTA_DE_PEDIDOS.OBTENER_INSTANCIA();
            ARMA_COMBOBOX_PROVEEDOR();
            ARMA_COMBOBOX_SOLICITUD_PEDIDO();

        }

        private void ARMA_COMBOBOX_PROVEEDOR()
        {
            cmbPROVEEDOR.DataSource = null;
            cmbPROVEEDOR.DataSource = cPROVEEDORES.OBTENER_PROVEEDORES();
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
            if (!double.TryParse(txtPRECIO1.Text, out PRECIO_UNITARIO))
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
            oLISTA_PEDIDO = new MODELO.LISTA_PEDIDO();
            ACCION = "A";

            oCONTIZACION.NOMBRE = txtNOMBRE.Text.ToUpper();
            oCONTIZACION.FECHA = DateTime.Now;
            oCONTIZACION.PROVEEDOR = (MODELO.PROVEEDOR)cmbPROVEEDOR.SelectedItem;
            oCONTIZACION.PEDIDO = (MODELO.SOLICITUD_PEDIDO)cmbSOLICITUD_PEDIDO.SelectedItem;
            oCONTIZACION.PRECIO = PRECIO_UNITARIO;
            oCONTIZACION.MOTIVO = txtMOTIVO.Text.ToUpper();
            //VER LA LISTA DE PEDIDOS
            oLISTA_PEDIDO.PEDIDO = (MODELO.SOLICITUD_PEDIDO)cmbSOLICITUD_PEDIDO.SelectedItem;
            

            if (ACCION == "A")
            {
                DialogResult RESPUESTA = MessageBox.Show("¿Está seguro que desea cotizar el pedido?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (RESPUESTA == DialogResult.Yes)
                {
                    cCOTIZACIONES.AGREGAR_COTIZACION(oCONTIZACION);                   
                    txtNOMBRE.Clear();
                    ARMA_COMBOBOX_PROVEEDOR();
                    ARMA_COMBOBOX_SOLICITUD_PEDIDO();
                    txtPRECIO1.Clear();
                    txtMOTIVO.Clear();
                }           
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSOLICITUD_PEDIDO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_SOLICITUD_PEDIDO solicitud_seleccionado = cmbSOLICITUD_PEDIDO.SelectedItem as CMB_SOLICITUD_PEDIDO;
            var LISTA_SOLICITUD = (from c in cLISTA_PEDIDOS.OBTENER_LISTA_PEDIDOS() where c.PEDIDO.ID_SOLICITUD_PEDIDO == solicitud_seleccionado.CMB_VALOR select c).ToList();
            int contador = 1;
            foreach (var material_solicitado in LISTA_SOLICITUD)
            {
                
                Control c = this.Controls.Find("lblPRECIO" + contador.ToString(), true).Single();
                (c as Label).Text = material_solicitado.INSUMO.NOMBRE;
                
                Control t = this.Controls.Find("txtPRECIO" + contador.ToString(), true).Single();
                (t as System.Windows.Forms.TextBox).Enabled = true;
                (t as System.Windows.Forms.TextBox).BackColor = Color.White;
                contador++;
            }
        }
        private void ARMA_COMBOBOX_SOLICITUD_PEDIDO()
        {
            //Traigo todos los profesionales que coincidan con la especialidad y esten en un estado activo
            cmbSOLICITUD_PEDIDO.DataSource = null;
            var LISTA_SOLICITUD = (from c in cSOLICITUDES_PEDIDOS.OBTENER_SOLICITUDES_PEDIDOS() select c).ToList();
            List<CMB_SOLICITUD_PEDIDO> LISTA_CMB_SOLICITUD = new List<CMB_SOLICITUD_PEDIDO>();

            cmbSOLICITUD_PEDIDO.ValueMember = "ID_SOLICITUD";
            cmbSOLICITUD_PEDIDO.DisplayMember = "NOMBRE";
            LISTA_CMB_SOLICITUD.Add(new CMB_SOLICITUD_PEDIDO("SELECCIONE...", -1));
            foreach (var SOLI in LISTA_SOLICITUD)
            {
                LISTA_CMB_SOLICITUD.Add(new CMB_SOLICITUD_PEDIDO(SOLI.DESCRIPCION, SOLI.ID_SOLICITUD_PEDIDO));
            }
            cmbSOLICITUD_PEDIDO.SelectedItem = "SELECCIONE...";
            cmbSOLICITUD_PEDIDO.DataSource = LISTA_CMB_SOLICITUD;

        }
        class CMB_SOLICITUD_PEDIDO
        {
            public string CMB_TEXTO { get; set; }
            public int CMB_VALOR { get; set; }
            public CMB_SOLICITUD_PEDIDO(string T, int V)
            {
                CMB_VALOR = V;
                CMB_TEXTO = T;
            }
            public override string ToString()
            {
                return CMB_TEXTO;
            }
        }

    }
}
