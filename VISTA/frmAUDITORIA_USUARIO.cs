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
    public partial class frmAUDITORIA_USUARIO : Form
    {
        private static frmAUDITORIA_USUARIO instancia;

        public static frmAUDITORIA_USUARIO OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmAUDITORIA_USUARIO();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmAUDITORIA_USUARIO();
            }
            return instancia;
        }

        CONTROLADORA.AUDITORIAS cAUDITORIAS;
        MODELO.AUDITORIA_USUARIO oAUDITORIA;

        public frmAUDITORIA_USUARIO()
        {
            InitializeComponent();
            cAUDITORIAS = CONTROLADORA.AUDITORIAS.OBTENER_INSTANCIA();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_ACCIONES_USUARIO.DataSource = null;
            dgvLISTA_ACCIONES_USUARIO.DataSource = cAUDITORIAS.OBTENER_AUDITORIA_USUARIOS();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_ACCIONES_USUARIO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una accion de la lista de la auditoria para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oAUDITORIA = (MODELO.AUDITORIA_USUARIO)dgvLISTA_ACCIONES_USUARIO.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar la accion " + oAUDITORIA.ACCION + " del usuario " + oAUDITORIA.NOMBRE + " de la lista de acciones de la auditoría?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cAUDITORIAS.ELIMINAR_AUDITORIA_USUARIO(oAUDITORIA);
                ARMA_GRILLA();
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
