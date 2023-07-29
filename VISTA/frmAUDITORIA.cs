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
    public partial class frmAUDITORIA : Form
    {
        private static frmAUDITORIA instancia;

        public static frmAUDITORIA OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmAUDITORIA();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmAUDITORIA();
            }
            return instancia;
        }

        CONTROLADORA.AUDITORIAS cAUDITORIAS;
        MODELO.AUDITORIA oAUDITORIA;
        
        public frmAUDITORIA()
        {
            InitializeComponent();

            cAUDITORIAS = CONTROLADORA.AUDITORIAS.OBTENER_INSTANCIA();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_ACCIONES.DataSource = null;           
            dgvLISTA_ACCIONES.DataSource = cAUDITORIAS.OBTENER_AUDITORIAS();
            // No puedo hacer andar correctamente el email del usuario, se muestra como MODELO.USUARIO
            dgvLISTA_ACCIONES.Columns["USUARIO"].Visible = false;
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_ACCIONES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una accion de la lista de la auditoria para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oAUDITORIA = (MODELO.AUDITORIA)dgvLISTA_ACCIONES.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar la accion " + oAUDITORIA.ACCION + " del usuario " + oAUDITORIA.USUARIO.EMAIL + " de la lista de acciones de la auditoría?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cAUDITORIAS.ELIMINAR_AUDITORIA(oAUDITORIA);
                ARMA_GRILLA();
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
