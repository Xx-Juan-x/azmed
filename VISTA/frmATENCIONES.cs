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
    public partial class frmATENCIONES : Form
    {
        private static frmATENCIONES instancia;

        public static frmATENCIONES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmATENCIONES();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmATENCIONES();
            }
            return instancia;
        }

        private CONTROLADORA.ATENCIONES cATENCIONES;
        private MODELO.USUARIO oUSUARIO;
        private CONTROLADORA.USUARIOS cUSUARIOS;
        private MODELO.ATENCION oATENCION;
        private CONTROLADORA.ESPECIALIDADES cESPECIALIDADES;
        string ACCION;


        public frmATENCIONES()
        {
            InitializeComponent();

            cATENCIONES = CONTROLADORA.ATENCIONES.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            cESPECIALIDADES = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();

            cmbDIA_LABORAL.Items.Add("LUNES");
            cmbDIA_LABORAL.Items.Add("MARTES");
            cmbDIA_LABORAL.Items.Add("MIERCOLES");
            cmbDIA_LABORAL.Items.Add("JUEVES");
            cmbDIA_LABORAL.Items.Add("VIERNES");
            cmbDIA_LABORAL.Items.Add("SABADO");
            cmbDIA_LABORAL.Items.Add("DOMINGO");

            cmbFILTRO_ESPECIALIDAD.Items.Add("TODOS");
            cmbFILTRO_ESPECIALIDAD.Items.Add("LUNES");
            cmbFILTRO_ESPECIALIDAD.Items.Add("MARTES");
            cmbFILTRO_ESPECIALIDAD.Items.Add("MIERCOLES");
            cmbFILTRO_ESPECIALIDAD.Items.Add("JUEVES");
            cmbFILTRO_ESPECIALIDAD.Items.Add("VIERNES");
            cmbFILTRO_ESPECIALIDAD.Items.Add("SABADO");
            cmbFILTRO_ESPECIALIDAD.Items.Add("DOMINGO");

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
                string FILTRO_ESPECIALIDAD = cmbFILTRO_ESPECIALIDAD.Text;

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

            /*dgvLISTA_ATENCIONES.AutoGenerateColumns = false;
            if (dgvLISTA_ATENCIONES.Columns.Contains("ESPECIALIDAD"))
            {
                dgvLISTA_ATENCIONES.Columns.Remove("ESPECIALIDAD");
            }*/
        }

        private void MODO_GRILLA()
        {
            gbLISTA_HORARIOS_ATENCION.Enabled = true;
            gbDATOS_PROFESIONAL_HORARIOS.Enabled = false;
            gbHORARIOS_ATENCION.Enabled = false;

            //cmbFILTRO_ESPECIALIDAD.DataSource = null;

            //AÑADO MI PROPIEDAD ESPECIALIDAD A MI LISTA DE PROFESIONAL
            //cmbFILTRO_ESPECIALIDAD.DataSource = cATENCIONES.OBTENER_ATENCIONES();
            //cmbFILTRO_ESPECIALIDAD.DisplayMember = "DIA_LABORAL";
            


            /*DataRow dr = cmbFILTRO_ESPECIALIDADES.NewRow();
            dr["CategoryName"] = "Select";
            dr["ID"] = 0;*/

        }

        private void MODO_DATOS()
        {
            gbLISTA_HORARIOS_ATENCION.Enabled = false;
            gbDATOS_PROFESIONAL_HORARIOS.Enabled = true;
            gbHORARIOS_ATENCION.Enabled = true;
        }

        private void ARMA_COMBOBOX_ESPECIALIDADES()
        {
            

            cmbESPECIALIDADES.DataSource = null;
            
            cmbESPECIALIDADES.ValueMember = "ID_ESPECIALIDAD";
            cmbESPECIALIDADES.DisplayMember = "NOMBRE";
            cmbESPECIALIDADES.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();

            cmbESPECIALIDADES.SelectedIndex = -1;

            int ESPECIALIDADES = Convert.ToInt32(cmbESPECIALIDADES.SelectedValue);
            ARMA_COMBOBOX_PROFESIONALES(ESPECIALIDADES);



        }

        private void ARMA_COMBOBOX_PROFESIONALES(int ID_ESPECIALIDAD)
        {
            
            cmbPROFESIONALES.DataSource = null;

            //cmbPROFESIONALES.DataSource = cUSUARIOS.OBTENER_PROFESIONALES().Where(x => x.ESPECIALIDADES == ID_ESPECIALIDAD).ToList();
            cmbPROFESIONALES.ValueMember = "ID_USUARIO";
            cmbPROFESIONALES.DisplayMember = "NOMBRE" + "APELLIDO";
           
        }


        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbFILTRO_ESPECIALIDAD.Text))
            {
                MessageBox.Show("Debe seleccionar una especialidad de la lista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ARMA_GRILLA("B");
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            oATENCION = new MODELO.ATENCION();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
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

            DateTime t1 = DateTime.Parse(dtpHORA_INICIO.Value.ToString());
            DateTime t2 = DateTime.Parse(dtpHORA_FIN.Value.ToString());
            int result = DateTime.Compare(t1, t2);
            if (result > 0)
            {
                MessageBox.Show("La hora de inicio no debe ser mayor a la de fin", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            //oATENCION = (MODELO.ATENCION)dgvLISTA_ATENCIONES.CurrentRow.DataBoundItem;


            oATENCION.HORA_INICIO = dtpHORA_INICIO.Value.TimeOfDay;
            oATENCION.HORA_FIN = dtpHORA_FIN.Value.TimeOfDay;
            oATENCION.DIA_LABORAL = cmbDIA_LABORAL.Text;
            oATENCION.ESPECIALIDAD = (MODELO.ESPECIALIDAD)cmbESPECIALIDADES.SelectedItem;
            oATENCION.PROFESIONAL = (MODELO.USUARIO)cmbPROFESIONALES.SelectedItem;

            //oATENCION.PROFESIONAL = (MODELO.USUARIO)txtPROFESIONAL.Text;

            //txtID_PROFESIONAL.Text = oATENCION.PROFESIONAL.ToString();

            if (ACCION == "A")
            {
                cATENCIONES.AGREGAR_ATENCION(oATENCION);
            }
            else
            {
                cATENCIONES.MODIFICAR_ATENCION(oATENCION);
            }
            
            ARMA_GRILLA("A");
            MODO_GRILLA();
        }

        private void cmbESPECIALIDADES_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbESPECIALIDADES.SelectedValue.ToString() != null)
            {
                string ID_ESPECIALIDAD = cmbESPECIALIDADES.SelectedValue.ToString();
                ARMA_COMBOBOX_PROFESIONALES(ID_ESPECIALIDAD);
                return;
            }
        }
    }
}
