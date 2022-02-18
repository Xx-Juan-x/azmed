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
    public partial class frmATENCION : Form
    {
        //PATRON SINGLETON
        private static frmATENCION instancia;

        public static frmATENCION OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmATENCION();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmATENCION();
            }
            return instancia;
        }

        private CONTROLADORA.ATENCIONES cATENCIONES;
        private MODELO.USUARIO oUSUARIO;
        private CONTROLADORA.USUARIOS cUSUARIOS;
        string ACCION;

        public frmATENCION()
        {
            InitializeComponent();
            cATENCIONES = CONTROLADORA.ATENCIONES.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            cmbDIA_LABORAL.Items.Add("LUNES");
            cmbDIA_LABORAL.Items.Add("MARTES");
            cmbDIA_LABORAL.Items.Add("MIERCOLES");
            cmbDIA_LABORAL.Items.Add("JUEVES");
            cmbDIA_LABORAL.Items.Add("VIERNES");
            cmbDIA_LABORAL.Items.Add("SABADO");
            cmbDIA_LABORAL.Items.Add("DOMINGO");
          
            ARMA_GRILLA();
            MODO_GRILLA();
            
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_ATENCION.DataSource = null;
            dgvLISTA_ATENCION.DataSource = cUSUARIOS.OBTENER_PROFESIONALES();
            
            dgvLISTA_ATENCION.AutoGenerateColumns = false;
            if (dgvLISTA_ATENCION.Columns.Contains("CLAVE") && dgvLISTA_ATENCION.Columns.Contains("FECHA") && dgvLISTA_ATENCION.Columns.Contains("TIPO"))
            {
                dgvLISTA_ATENCION.Columns.Remove("FECHA");
                dgvLISTA_ATENCION.Columns.Remove("CLAVE");
                dgvLISTA_ATENCION.Columns.Remove("TIPO");
            }
        }

        private void MODO_GRILLA()
        {
            gbLISTA_HORARIOS_ATENCION.Enabled = true;
            gbDATOS_PROFESIONAL_HORARIOS.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_HORARIOS_ATENCION.Enabled = false;
            gbDATOS_PROFESIONAL_HORARIOS.Enabled = true;            
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbDIA_LABORAL.Text))
            {
                MessageBox.Show("Debe seleccionar un dia laboral.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DateTime t1 = DateTime.Parse(dtpHORA_INICIO.Value.ToString());
            DateTime t2 = DateTime.Parse(dtpHORA_FIN.Value.ToString());
            int result = DateTime.Compare(t1, t2);
            if (result > 0)
            {
                MessageBox.Show("La hora de inicio no debe ser mayor a la de fin", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_ATENCION.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oUSUARIO = (MODELO.USUARIO)dgvLISTA_ATENCION.CurrentRow.DataBoundItem;


            

            MODO_DATOS();
            
        }
    }
}
