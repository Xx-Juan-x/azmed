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
    public partial class frmSOLICITAR_PEDIDO_INSUMO : Form
    {
        private static frmSOLICITAR_PEDIDO_INSUMO instancia;

        public static frmSOLICITAR_PEDIDO_INSUMO OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmSOLICITAR_PEDIDO_INSUMO();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmSOLICITAR_PEDIDO_INSUMO();
            }
            return instancia;
        }

        private CONTROLADORA.SOLICITUDES_DE_PEDIDOS cSOLICITUDES_PEDIDOS;
        private CONTROLADORA.MATERIALES cMATERIALES;
        private CONTROLADORA.LISTA_DE_PEDIDOS cLISTA_PEDIDOS;
        private MODELO.SOLICITUD_PEDIDO oSOLICITUD_PEDIDO;
        private MODELO.LISTA_PEDIDO oLISTA_PEDIDO;
        private MODELO.MATERIAL oMATERIAL;

        public frmSOLICITAR_PEDIDO_INSUMO()
        {
            InitializeComponent();
            cMATERIALES = CONTROLADORA.MATERIALES.OBTENER_INSTANCIA();
            cSOLICITUDES_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            cLISTA_PEDIDOS = CONTROLADORA.LISTA_DE_PEDIDOS.OBTENER_INSTANCIA();
            ARMAR_COMBOBOX_MATERIAL();
        }
        class CMB_MATERIAL {
            public string texto{get; set;}
            public int id{get; set; }
            public CMB_MATERIAL(string T,int I)
            {
                texto = T;
                id = I;
            }
        }
        private void ARMAR_COMBOBOX_MATERIAL()
        {
            List<CMB_MATERIAL> lista_materiales = new List<CMB_MATERIAL>();

            foreach (var item in cMATERIALES.OBTENER_MATERIALES())
           {
                lista_materiales.Add(new CMB_MATERIAL(item.NOMBRE,item.ID_MATERIAL));
            }
            //List<CONTROLADORA.MATERIALES> oMATERIAL = cMATERIALES.OBTENER_MATERIALES();

            cmbMATERIAL_1.DisplayMember = "texto";
            cmbMATERIAL_1.ValueMember = "id";
            cmbMATERIAL_2.DisplayMember = "texto";
            cmbMATERIAL_2.ValueMember = "id";
            cmbMATERIAL_3.DisplayMember = "texto";
            cmbMATERIAL_3.ValueMember = "id";
            cmbMATERIAL_4.DisplayMember = "texto";
            cmbMATERIAL_4.ValueMember = "id";
            cmbMATERIAL_5.DisplayMember = "texto";
            cmbMATERIAL_5.ValueMember = "id";
            cmbMATERIAL_6.DisplayMember = "texto";
            cmbMATERIAL_6.ValueMember = "id";
            cmbMATERIAL_7.DisplayMember = "texto";
            cmbMATERIAL_7.ValueMember = "id";
            cmbMATERIAL_8.DisplayMember = "texto";
            cmbMATERIAL_8.ValueMember = "id";
            cmbMATERIAL_9.DisplayMember = "texto";
            cmbMATERIAL_9.ValueMember = "id";
            cmbMATERIAL_10.DisplayMember = "texto";
            cmbMATERIAL_10.ValueMember = "id";

            cmbMATERIAL_1.DataSource = lista_materiales;
            cmbMATERIAL_2.DataSource = lista_materiales;
            cmbMATERIAL_3.DataSource = lista_materiales;
            cmbMATERIAL_4.DataSource = lista_materiales;
            cmbMATERIAL_5.DataSource = lista_materiales;
            cmbMATERIAL_6.DataSource = lista_materiales;
            cmbMATERIAL_7.DataSource = lista_materiales;
            cmbMATERIAL_8.DataSource = lista_materiales;
            cmbMATERIAL_9.DataSource = lista_materiales;
            cmbMATERIAL_10.DataSource = lista_materiales;
            
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnENVIAR_Click_1(object sender, EventArgs e)
        {
            oSOLICITUD_PEDIDO = new MODELO.SOLICITUD_PEDIDO();
            oLISTA_PEDIDO = new MODELO.LISTA_PEDIDO();
            //VER COMO HACER PARA QUE ESTO SE SUBA EN DISTINTOS REGISTROS
            oSOLICITUD_PEDIDO.DESCRIPCION = txtDESCRIPCION.Text.ToUpper();
            oSOLICITUD_PEDIDO.FECHA = DateTime.Today;
            oSOLICITUD_PEDIDO.ESTADO = "EN PROCESO";
            cSOLICITUDES_PEDIDOS.AGREGAR_SOLICITUD_PEDIDO(oSOLICITUD_PEDIDO);
            var ULTIMA_SOLICITUD = cSOLICITUDES_PEDIDOS.OBTENER_SOLICITUDES_PEDIDOS().Last();
            /* var ULTIMA_SOLICITUD = from a in cSOLICITUDES_PEDIDOS.OBTENER_SOLICITUDES_PEDIDOS()
                                    where a.ID_SOLICITUD_PEDIDO.*/
            oSOLICITUD_PEDIDO.ID_SOLICITUD_PEDIDO = ULTIMA_SOLICITUD.ID_SOLICITUD_PEDIDO;
            oLISTA_PEDIDO.PEDIDO = oSOLICITUD_PEDIDO;

            // oLISTA_PEDIDO.PEDIDO = 
            //VER LA LISTA DE PEDIDOS
            
            int[] ARRAY_CMB = new int[] { };
            CMB_MATERIAL VALOR_MATERIAL_1 = cmbMATERIAL_1.SelectedItem as CMB_MATERIAL;
            CMB_MATERIAL VALOR_MATERIAL_2 = cmbMATERIAL_2.SelectedItem as CMB_MATERIAL;
            CMB_MATERIAL VALOR_MATERIAL_3 = cmbMATERIAL_3.SelectedItem as CMB_MATERIAL;
            CMB_MATERIAL VALOR_MATERIAL_4 = cmbMATERIAL_4.SelectedItem as CMB_MATERIAL;
            CMB_MATERIAL VALOR_MATERIAL_5 = cmbMATERIAL_5.SelectedItem as CMB_MATERIAL;
            CMB_MATERIAL VALOR_MATERIAL_6 = cmbMATERIAL_6.SelectedItem as CMB_MATERIAL;
            CMB_MATERIAL VALOR_MATERIAL_7 = cmbMATERIAL_7.SelectedItem as CMB_MATERIAL;
            CMB_MATERIAL VALOR_MATERIAL_8  = cmbMATERIAL_8.SelectedItem as CMB_MATERIAL;
            CMB_MATERIAL VALOR_MATERIAL_9 = cmbMATERIAL_9.SelectedItem as CMB_MATERIAL;
            CMB_MATERIAL VALOR_MATERIAL_10 = cmbMATERIAL_10.SelectedItem as CMB_MATERIAL;

            ARRAY_CMB.Append(VALOR_MATERIAL_1.id);
            ARRAY_CMB.Append(VALOR_MATERIAL_2.id);
            ARRAY_CMB.Append(VALOR_MATERIAL_3.id);
            ARRAY_CMB.Append(VALOR_MATERIAL_4.id);
            ARRAY_CMB.Append(VALOR_MATERIAL_5.id);
            ARRAY_CMB.Append(VALOR_MATERIAL_6.id);
            ARRAY_CMB.Append(VALOR_MATERIAL_7.id);
            ARRAY_CMB.Append(VALOR_MATERIAL_8.id);
            ARRAY_CMB.Append(VALOR_MATERIAL_9.id);
            ARRAY_CMB.Append(VALOR_MATERIAL_10.id);
           
            int[] ARRAY_SELECTED = new int[] { };
            for (int i = 0; i < 10; i++)
            {
                //VALIDA SI EL ITEM QUE SE ESTÁ POR AGREGAR NO SE REPITE EN EL ARRAY Y TAMPOCO ES "SELECCIONE..."
                if (ARRAY_SELECTED.Contains(ARRAY_CMB[i]) == false && ARRAY_CMB[i] != 1)
                {
                    //AGREGA AL ARRAY UN NUEVO ÍNDICE
                    ARRAY_SELECTED.Append(ARRAY_CMB[i]);
                }
            }
            //RECORRE Y AGREGA TODOS LOS ITEMS SELECCIONADOS QUE YA FUERON VALIDADOS ANTERIORMENTE
            for (int i = 0; i < ARRAY_SELECTED.Length; i++)
            {
                oLISTA_PEDIDO.INSUMO.ID_MATERIAL = ARRAY_SELECTED[i];
                //GUARDAR material en LISTA_PEDIDO.
                cLISTA_PEDIDOS.AGREGAR_LISTA_PEDIDO(oLISTA_PEDIDO);             
            }                                      
        }
      
    }
}
