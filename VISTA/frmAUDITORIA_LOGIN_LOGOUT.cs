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
    public partial class frmAUDITORIA_LOGIN_LOGOUT : Form
    {
        private static frmAUDITORIA_LOGIN_LOGOUT instancia;

        public static frmAUDITORIA_LOGIN_LOGOUT OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmAUDITORIA_LOGIN_LOGOUT();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmAUDITORIA_LOGIN_LOGOUT();
            }
            return instancia;
        }

        CONTROLADORA.AUDITORIAS cAUDITORIAS;
        MODELO.AUDITORIA_LOGIN_LOGOUT oAUDITORIA;
        
        public frmAUDITORIA_LOGIN_LOGOUT()
        {
            InitializeComponent();

            cAUDITORIAS = CONTROLADORA.AUDITORIAS.OBTENER_INSTANCIA();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_ACCIONES_LOGIN_LOGOUT.DataSource = null;           
            dgvLISTA_ACCIONES_LOGIN_LOGOUT.DataSource = cAUDITORIAS.OBTENER_AUDITORIAS();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_ACCIONES_LOGIN_LOGOUT.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una accion de la lista de la auditoria para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oAUDITORIA = (MODELO.AUDITORIA_LOGIN_LOGOUT)dgvLISTA_ACCIONES_LOGIN_LOGOUT.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar la accion " + oAUDITORIA.ACCION + " del usuario " + oAUDITORIA.USUARIO + " de la lista de acciones de la auditoría?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
