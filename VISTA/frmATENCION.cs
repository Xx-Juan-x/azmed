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
        private CONTROLADORA.ESPECIALIDADES cESPECIALIDADES;
        string ACCION;


        public frmATENCION()
        {
            InitializeComponent();

            cATENCIONES = CONTROLADORA.ATENCIONES.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            cESPECIALIDADES = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();
         
            cmbDIA_LABORAL.Items.Add("SELECCIONE...");
            cmbDIA_LABORAL.SelectedItem = "SELECCIONE...";

            cmbFILTRO_DIA_LABORAL.Items.Add("TODOS");
            cmbFILTRO_DIA_LABORAL.Items.Add("LUNES");
            cmbFILTRO_DIA_LABORAL.Items.Add("MARTES");
            cmbFILTRO_DIA_LABORAL.Items.Add("MIERCOLES");
            cmbFILTRO_DIA_LABORAL.Items.Add("JUEVES");
            cmbFILTRO_DIA_LABORAL.Items.Add("VIERNES");
            cmbFILTRO_DIA_LABORAL.Items.Add("SABADO");
            cmbFILTRO_DIA_LABORAL.Items.Add("DOMINGO");
            cmbFILTRO_DIA_LABORAL.SelectedItem = "TODOS";

            ARMA_COMBOBOX_ESPECIALIDADES();
            
            ARMA_GRILLA("A"); 
            MODO_GRILLA();
        }

        private void ARMA_GRILLA(string TIPO)
        {
            if (TIPO == "A")
            {
                dgvLISTA_ATENCIONES.DataSource = null;
                dgvLISTA_ATENCIONES.DataSource = cATENCIONES.OBTENER_ATENCIONES();
            }
            if (TIPO == "B")
            {
                string FILTRO_ESPECIALIDAD = cmbFILTRO_DIA_LABORAL.Text;

                if (FILTRO_ESPECIALIDAD == "TODOS")
                {
                    dgvLISTA_ATENCIONES.DataSource = null;
                    dgvLISTA_ATENCIONES.DataSource = cATENCIONES.OBTENER_ATENCIONES();
                }
                else
                {
                    var LISTA_ESPECIALIDADES = (from a in cATENCIONES.OBTENER_ATENCIONES()
                                                where a.DIA_LABORAL == FILTRO_ESPECIALIDAD
                                                select a).ToList();

                    dgvLISTA_ATENCIONES.DataSource = null;
                    dgvLISTA_ATENCIONES.DataSource = LISTA_ESPECIALIDADES;
                }
            }         
        }

        private void MODO_GRILLA()
        {
            gbLISTA_HORARIOS_ATENCION.Enabled = true;
            gbDATOS_PROFESIONAL_HORARIOS.Enabled = false;
            gbHORARIOS_ATENCION.Enabled = false;
            btnAGREGAR.Visible = true;
            btnMODIFICAR.Visible = true;
            btnCONSULTAR.Visible = true;
            btnELIMINAR.Visible = true;
            gbDATOS_PROFESIONAL_HORARIOS.Visible = true;
            gbHORARIOS_ATENCION.Visible = true;          
        }

        private void MODO_DATOS()
        {
            if (ACCION == "A")
            {
                gbLISTA_HORARIOS_ATENCION.Enabled = false;
                gbDATOS_PROFESIONAL_HORARIOS.Enabled = true;
                gbHORARIOS_ATENCION.Enabled = true;
                cmbPROFESIONALES.Enabled = true;
                btnGUARDAR.Enabled = true;
            }
            if (ACCION == "M")
            {
                gbLISTA_HORARIOS_ATENCION.Enabled = false;
                gbDATOS_PROFESIONAL_HORARIOS.Enabled = false;
                gbHORARIOS_ATENCION.Enabled = true;
                btnGUARDAR.Enabled = true;
            }
            if (ACCION == "C")
            {
                gbLISTA_HORARIOS_ATENCION.Enabled = false;
                gbDATOS_PROFESIONAL_HORARIOS.Enabled = false;
                gbHORARIOS_ATENCION.Enabled = true;
                btnGUARDAR.Enabled = false;
            }
        }

        private void ARMA_COMBOBOX_ESPECIALIDADES()
        {
                cmbESPECIALIDADES.DataSource = null;
                cmbESPECIALIDADES.Items.Add("SELECCIONE...");
                cmbESPECIALIDADES.SelectedItem = "SELECCIONE...";           
        }

        private void ARMA_COMBOBOX_PROFESIONALES(int ID_ESPECIALIDAD)
        {
            cmbPROFESIONALES.DataSource = null;           
            var LISTA_PROFESIONALES = (from c in cUSUARIOS.OBTENER_PROFESIONALES()
                                       where c.ESPECIALIDADES.ID_ESPECIALIDAD == ID_ESPECIALIDAD
                                       select c).ToList();

            cmbPROFESIONALES.DataSource = LISTA_PROFESIONALES;
            cmbPROFESIONALES.ValueMember = "ID_USUARIO";
            cmbPROFESIONALES.DisplayMember = "NOMBRE" + "APELLIDO";
        }

        private void btnBUSCAR_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbFILTRO_DIA_LABORAL.Text))
            {
                MessageBox.Show("Debe seleccionar una especialidad de la lista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbFILTRO_DIA_LABORAL.SelectedItem.ToString() == "TODOS")
            {
                ARMA_GRILLA("A");
            }
            else
            {
                ARMA_GRILLA("B");
            }          
        }

        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            oATENCION = new MODELO.ATENCION();            
            ACCION = "A";

            cmbESPECIALIDADES.ValueMember = "ID_ESPECIALIDAD";
            cmbESPECIALIDADES.DisplayMember = "NOMBRE";
            cmbESPECIALIDADES.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();
            cmbDIA_LABORAL.Enabled = true;
            MODO_DATOS();
        }

        private void btnGUARDAR_Click_1(object sender, EventArgs e)
        {
            #region VALIDACIONES

            if (string.IsNullOrEmpty(cmbESPECIALIDADES.Text))
            {
                MessageBox.Show("Debe seleccionar una especialidad", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbPROFESIONALES.Text))
            {
                MessageBox.Show("Debe seleccionar un profesional", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbDIA_LABORAL.Text))
            {
                MessageBox.Show("Debe seleccionar un dia laboral.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int HORA_INICIO = Convert.ToInt32(numericHORA_INICIO.Value);
            int HORA_FIN = Convert.ToInt32(numericHORA_FIN.Value);

            if (HORA_INICIO >= HORA_FIN)
            {
                MessageBox.Show("La hora de inicio no puede ser mayor que la hora fin", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDIA_LABORAL.SelectedItem.ToString() == "SELECCIONE...")
            {
                MessageBox.Show("Debe seleccionar el día laboral del profesional", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            oATENCION.HORA_INICIO = HORA_INICIO;
            oATENCION.HORA_FIN = HORA_FIN;
            oATENCION.DIA_LABORAL = cmbDIA_LABORAL.Text;
            oATENCION.ESPECIALIDAD = (MODELO.ESPECIALIDAD)cmbESPECIALIDADES.SelectedItem;
            oATENCION.PROFESIONAL = (MODELO.USUARIO)cmbPROFESIONALES.SelectedItem;
            
            if (ACCION == "A")
            {
                cATENCIONES.AGREGAR_ATENCION(oATENCION);
                ARMA_GRILLA("A");
            }
            else
            {
                cATENCIONES.MODIFICAR_ATENCION(oATENCION);
                ARMA_GRILLA("B");
            }
                 
            MODO_GRILLA();
        }      

        private void btnMODIFICAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_ATENCIONES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una atencion de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oATENCION = (MODELO.ATENCION)dgvLISTA_ATENCIONES.CurrentRow.DataBoundItem;

            ACCION = "M";

            cmbESPECIALIDADES.ValueMember = "ID_ESPECIALIDAD";
            cmbESPECIALIDADES.DisplayMember = "NOMBRE";
            cmbESPECIALIDADES.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();

            cmbESPECIALIDADES.Text = oATENCION.ESPECIALIDAD.ToString();
            cmbPROFESIONALES.Text = oATENCION.PROFESIONAL.ToString();
            numericHORA_INICIO.Value = oATENCION.HORA_INICIO;
            numericHORA_FIN.Value = oATENCION.HORA_FIN;
            cmbDIA_LABORAL.Text = oATENCION.DIA_LABORAL.ToString();
            cmbDIA_LABORAL.Enabled = false;

            ARMA_GRILLA("B");
            MODO_DATOS();
        }

        private void cmbESPECIALIDADES_SelectedIndexChanged_1(object sender, EventArgs e)
        {           
                int ID_ESPECIALIDAD = Convert.ToInt32(cmbESPECIALIDADES.SelectedValue);
                ARMA_COMBOBOX_PROFESIONALES(ID_ESPECIALIDAD);
                return;                 
        }
        
        private void btnCONSULTAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_ATENCIONES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una atencion de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oATENCION = (MODELO.ATENCION)dgvLISTA_ATENCIONES.CurrentRow.DataBoundItem;

            ACCION = "C";

            cmbESPECIALIDADES.ValueMember = "ID_ESPECIALIDAD";
            cmbESPECIALIDADES.DisplayMember = "NOMBRE";
            cmbESPECIALIDADES.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();

            cmbESPECIALIDADES.Text = oATENCION.ESPECIALIDAD.ToString();
            cmbPROFESIONALES.Text = oATENCION.PROFESIONAL.ToString();
            numericHORA_INICIO.Value = oATENCION.HORA_INICIO;
            numericHORA_FIN.Value = oATENCION.HORA_FIN;
            cmbDIA_LABORAL.Text = oATENCION.DIA_LABORAL.ToString();
            cmbDIA_LABORAL.Enabled = false;

            MODO_DATOS();
        }

        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_ATENCIONES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una atencion de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oATENCION = (MODELO.ATENCION)dgvLISTA_ATENCIONES.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar la atencion del profesional " + oATENCION.PROFESIONAL + " con especialidad " + oATENCION.ESPECIALIDAD + " de la lista de atenciones?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cATENCIONES.ELIMINAR_ATENCION(oATENCION);
                if (cmbFILTRO_DIA_LABORAL.SelectedItem.ToString() == "TODOS")
                {
                    ARMA_GRILLA("A");
                }
                else
                {
                    ARMA_GRILLA("B");
                }
            }
        }

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        { 
            MODO_GRILLA();
        }

        private void btnCERRAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPROFESIONALES_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ACCION == "A")
            {
                //cmbPROFESIONALES.DataSource = null;
                var LISTA_DIAS_PROFESIONAL = (from c in cATENCIONES.OBTENER_ATENCIONES()
                                              where c.PROFESIONAL.ID_USUARIO == Convert.ToInt32(cmbPROFESIONALES.SelectedValue)
                                              select c.DIA_LABORAL).ToList();
                List<string> LISTA_DIA = new List<string>();
                LISTA_DIA.Add("LUNES");
                LISTA_DIA.Add("MARTES");
                LISTA_DIA.Add("MIERCOLES");
                LISTA_DIA.Add("JUEVES");
                LISTA_DIA.Add("VIERNES");
                LISTA_DIA.Add("SABADO");
                LISTA_DIA.Add("DOMINGO");

                var DIAS_NO_AGREGADOS = LISTA_DIA.Except(LISTA_DIAS_PROFESIONAL).ToList();
                cmbDIA_LABORAL.DataSource = DIAS_NO_AGREGADOS;
            }
            else if (ACCION == "M" || ACCION == "C")
            {
                //cmbPROFESIONALES.DataSource = null;
                var LISTA_DIAS_PROFESIONAL = (from c in cATENCIONES.OBTENER_ATENCIONES()
                                              where c.PROFESIONAL.ID_USUARIO == Convert.ToInt32(cmbPROFESIONALES.SelectedValue)
                                              select c.DIA_LABORAL).ToList();

                cmbDIA_LABORAL.DataSource = LISTA_DIAS_PROFESIONAL;
            }         
        }       
    }
}
