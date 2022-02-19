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
        private MODELO.ATENCION oATENCION;
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

            ARMAR_GRILLA_PROFESIONALES();
            ARMA_GRILLA_ATENCIONES();

            MODO_GRILLA();
            
        }

        private void ARMAR_GRILLA_PROFESIONALES()
        {
            dgvLISTA_PROFESIONALES.DataSource = null;
            dgvLISTA_PROFESIONALES.DataSource = cUSUARIOS.OBTENER_PROFESIONALES();

            dgvLISTA_PROFESIONALES.AutoGenerateColumns = false;
            if (dgvLISTA_PROFESIONALES.Columns.Contains("CLAVE") && dgvLISTA_PROFESIONALES.Columns.Contains("FECHA") && dgvLISTA_PROFESIONALES.Columns.Contains("TIPO"))
            {
                dgvLISTA_PROFESIONALES.Columns.Remove("FECHA");
                dgvLISTA_PROFESIONALES.Columns.Remove("CLAVE");
                dgvLISTA_PROFESIONALES.Columns.Remove("TIPO");
            }
        }


        private void ARMA_GRILLA_ATENCIONES()
        {          
            dgvLISTA_ATENCIONES.DataSource = null;
            dgvLISTA_ATENCIONES.DataSource = cATENCIONES.OBTENER_ATENCIONES();                 

            dgvLISTA_ATENCIONES.AutoGenerateColumns = false;
            if (dgvLISTA_ATENCIONES.Columns.Contains("ID_ATENCION"))
            {
                dgvLISTA_ATENCIONES.Columns.Remove("ID_ATENCION");
            }
        }

        private void MODO_GRILLA()
        {
            gbLISTA_HORARIOS_ATENCION.Enabled = true;
            gbDATOS_PROFESIONAL_HORARIOS.Enabled = false;
            gbHORARIOS_ATENCION.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_HORARIOS_ATENCION.Enabled = false;
            gbDATOS_PROFESIONAL_HORARIOS.Enabled = false;
            gbHORARIOS_ATENCION.Enabled = true;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
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
            #endregion

            oATENCION.HORA_INICIO = dtpHORA_INICIO.Value;
            oATENCION.HORA_FIN = dtpHORA_FIN.Value;
            oATENCION.DIA_LABORAL = cmbDIA_LABORAL.Text;
            //oATENCION.PROFESIONAL.ID_USUARIO = ;

            if (ACCION == "A")
            {
                cATENCIONES.AGREGAR_ATENCION(oATENCION);

            }
            else
            {
                cATENCIONES.MODIFICAR_ATENCION(oATENCION);
            }

            ARMA_GRILLA_ATENCIONES();
            MODO_GRILLA();

            // LIMPIO LA TEXTBOX
            dtpHORA_INICIO = null;
            dtpHORA_FIN = null;
            cmbDIA_LABORAL = null;

        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            oATENCION = new MODELO.ATENCION();

            if (dgvLISTA_PROFESIONALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oUSUARIO = (MODELO.USUARIO)dgvLISTA_PROFESIONALES.CurrentRow.DataBoundItem;

            txtESPECIALIDAD.Text = oUSUARIO.ESPECIALIDADES.ToString();
            txtPROFESIONAL.Text = oUSUARIO.NOMBRE + " " + oUSUARIO.APELLIDO;       
            MODO_DATOS();         
        }
    }
}
