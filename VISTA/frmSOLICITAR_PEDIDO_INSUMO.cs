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
        private MODELO.SOLICITUD_PEDIDO oSOLICITUD_PEDIDO;
             

        public frmSOLICITAR_PEDIDO_INSUMO()
        {
            InitializeComponent();           
            cMATERIALES = CONTROLADORA.MATERIALES.OBTENER_INSTANCIA();
            cSOLICITUDES_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            ARMAR_COMBOBOX_MATERIAL();
        }

        private void ARMAR_COMBOBOX_MATERIAL()
        {          
            cmbMATERIAL_1.DataSource = cMATERIALES.OBTENER_MATERIALES();
            cmbMATERIAL_2.DataSource = cMATERIALES.OBTENER_MATERIALES();
            cmbMATERIAL_3.DataSource = cMATERIALES.OBTENER_MATERIALES();
            cmbMATERIAL_4.DataSource = cMATERIALES.OBTENER_MATERIALES();
            cmbMATERIAL_5.DataSource = cMATERIALES.OBTENER_MATERIALES();
            cmbMATERIAL_6.DataSource = cMATERIALES.OBTENER_MATERIALES();
            cmbMATERIAL_7.DataSource = cMATERIALES.OBTENER_MATERIALES();
            cmbMATERIAL_8.DataSource = cMATERIALES.OBTENER_MATERIALES();
            cmbMATERIAL_9.DataSource = cMATERIALES.OBTENER_MATERIALES();
            cmbMATERIAL_10.DataSource = cMATERIALES.OBTENER_MATERIALES();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnENVIAR_Click_1(object sender, EventArgs e)
        {
            if (cmbMATERIAL_1.DataSource == null)
            {
                MessageBox.Show("Debe ingresar al menos un material para poder enviar un pedido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            oSOLICITUD_PEDIDO = new MODELO.SOLICITUD_PEDIDO();           
                //VER COMO HACER PARA QUE ESTO SE SUBA EN DISTINTOS REGISTROS
            oSOLICITUD_PEDIDO.NOMBRE = cmbMATERIAL_1.SelectedItem.ToString();
            oSOLICITUD_PEDIDO.FECHA = DateTime.Now;

            cSOLICITUDES_PEDIDOS.AGREGAR_SOLICITUD_PEDIDO(oSOLICITUD_PEDIDO);
                    
        }
      
    }
}
