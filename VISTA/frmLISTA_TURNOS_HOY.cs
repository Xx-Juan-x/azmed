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
    public partial class frmLISTA_TURNOS_HOY : Form
    {
        private static frmLISTA_TURNOS_HOY instancia;

        public static frmLISTA_TURNOS_HOY OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmLISTA_TURNOS_HOY();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmLISTA_TURNOS_HOY();
            }
            return instancia;
        }

        private CONTROLADORA.TURNOS cTURNOS;
        private MODELO.TURNO oTURNO;

        public frmLISTA_TURNOS_HOY()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            DateTime DIA_ACTUAL = DateTime.Now;

                var LISTA_TURNOS_PACIENTE_HOY = (from a in cTURNOS.OBTENER_TURNOS()
                                             where a.FECHA.Date == DIA_ACTUAL.Date
                                             select a).ToList();

                dgvLISTA_TURNOS_HOY.DataSource = null;
                dgvLISTA_TURNOS_HOY.DataSource = LISTA_TURNOS_PACIENTE_HOY;    
            
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTOMAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_TURNOS_HOY.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de hoy de la lista para poder tomarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oTURNO = (MODELO.TURNO)dgvLISTA_TURNOS_HOY.CurrentRow.DataBoundItem;

            if (oTURNO.ESTADO == "SOLICITADO")
            {
                DialogResult RESPUESTA = MessageBox.Show("¿Está seguro de modificar el estado " + oTURNO.ESTADO + " a TOMADO?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (RESPUESTA == DialogResult.Yes)
                {
                    oTURNO.ESTADO = "TOMADO";
                    cTURNOS.MODIFICAR_TURNO(oTURNO);
                    ARMA_GRILLA();
                }
            }
            else
            {
                MessageBox.Show("El turno ya está tomado, facturado o cancelado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_TURNOS_HOY.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de hoy de la lista para poder cancelarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oTURNO = (MODELO.TURNO)dgvLISTA_TURNOS_HOY.CurrentRow.DataBoundItem;

            if (oTURNO.ESTADO == "SOLICITADO")
            {
                DialogResult RESPUESTA = MessageBox.Show("¿Está seguro de modificar el estado " + oTURNO.ESTADO + " a CANCELADO?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (RESPUESTA == DialogResult.Yes)
                {
                    oTURNO.ESTADO = "CANCELADO";
                    cTURNOS.MODIFICAR_TURNO(oTURNO);
                    ARMA_GRILLA();
                }
            }
            else
            {
                MessageBox.Show("El turno ya está cancelado, tomado o facturado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
