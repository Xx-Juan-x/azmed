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
    public partial class frmLISTA_TURNOS_PROFESIONAL : Form
    {
        //PATRON SINGLETON
        private static frmLISTA_TURNOS_PROFESIONAL instancia;

        public static frmLISTA_TURNOS_PROFESIONAL OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmLISTA_TURNOS_PROFESIONAL();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmLISTA_TURNOS_PROFESIONAL();
            }
            return instancia;
        }

        private CONTROLADORA.TURNOS cTURNOS;
        private CONTROLADORA.PROFESIONALES cPROFESIONALES;
        private MODELO.TURNO oTURNO;
        public static string ACCION;

        public frmLISTA_TURNOS_PROFESIONAL()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            cPROFESIONALES = CONTROLADORA.PROFESIONALES.OBTENER_INSTANCIA();

            cmbFILTRO_DIA_LABORAL.Items.Add("TODOS");
            cmbFILTRO_DIA_LABORAL.Items.Add("LUNES");
            cmbFILTRO_DIA_LABORAL.Items.Add("MARTES");
            cmbFILTRO_DIA_LABORAL.Items.Add("MIERCOLES");
            cmbFILTRO_DIA_LABORAL.Items.Add("JUEVES");
            cmbFILTRO_DIA_LABORAL.Items.Add("VIERNES");
            cmbFILTRO_DIA_LABORAL.Items.Add("SABADO");
            cmbFILTRO_DIA_LABORAL.Items.Add("DOMINGO");
            cmbFILTRO_DIA_LABORAL.SelectedItem = "TODOS";

            
            ARMA_GRILLA("A");
            ARMA_COMBOBOX_PROFESIONAL();
        }
        class COMBOBOX_PROF
        {
            public string CMB_TEXTO { get; set; }
            public int CMB_VALOR { get; set; }
            public COMBOBOX_PROF(string T, int V)
            {
                CMB_TEXTO = T;
                CMB_VALOR = V;
            }
        }
        private void ARMA_COMBOBOX_PROFESIONAL()
        {
            cmbFILTRO_PROFESIONAL.DataSource = null;
            var listas_prof = cPROFESIONALES.OBTENER_PROFESIONALES().ToList();

            List<COMBOBOX_PROF> LISTA_CMB_PROF = new List<COMBOBOX_PROF>();
            LISTA_CMB_PROF.Add(new COMBOBOX_PROF("TODOS", 0));
            cmbFILTRO_PROFESIONAL.ValueMember = "CMB_VALOR";
            cmbFILTRO_PROFESIONAL.DisplayMember = "CMB_TEXTO";
            foreach (var prof in listas_prof)
            {
                LISTA_CMB_PROF.Add(new COMBOBOX_PROF(prof.NOMBRE + " " + prof.APELLIDO, prof.ID_PROFESIONAL));
            }
            cmbFILTRO_PROFESIONAL.DataSource = LISTA_CMB_PROF;
            cmbFILTRO_DIA_LABORAL.SelectedItem = "TODOS";


        }

        public void ARMA_GRILLA(string TIPO)
        {
            string FILTRO_DIA_LABORAL = cmbFILTRO_DIA_LABORAL.Text;
            int FILTRO_PROFESIONAL = Convert.ToInt32(cmbFILTRO_PROFESIONAL.SelectedValue ?? 0);
            //Todos los dias
            if (TIPO == "A")
            {
                dynamic LISTA_TURNOS_PROFESIONAL;
                if (FILTRO_PROFESIONAL == 0)
                {
                    LISTA_TURNOS_PROFESIONAL = (from a in cTURNOS.OBTENER_TURNOS()
                                                    select a).ToList();
                }
                else
                {
                    LISTA_TURNOS_PROFESIONAL = (from a in cTURNOS.OBTENER_TURNOS()
                                                    where a.PROFESIONAL.ID_PROFESIONAL == FILTRO_PROFESIONAL
                                                    select a).ToList();
                }

                dgvLISTA_TURNOS.DataSource = null;
                BindingSource source = new BindingSource();
                source.DataSource = LISTA_TURNOS_PROFESIONAL;
                dgvLISTA_TURNOS.DataSource = source;
                dgvLISTA_TURNOS.Update();
                dgvLISTA_TURNOS.Refresh();
            }

            //Un dia seleccionado
            if (TIPO == "B")
            {
                dynamic LISTA_TURNOS_PROFESIONAL;
                if (FILTRO_PROFESIONAL == 0)
                {
                    LISTA_TURNOS_PROFESIONAL = (from a in cTURNOS.OBTENER_TURNOS()
                                                where a.DIA == FILTRO_DIA_LABORAL
                                                select a).ToList();
                }
                else
                {
                    LISTA_TURNOS_PROFESIONAL = (from a in cTURNOS.OBTENER_TURNOS()
                                                where a.DIA == FILTRO_DIA_LABORAL && a.PROFESIONAL.ID_PROFESIONAL == FILTRO_PROFESIONAL
                                                select a).ToList();
                }

                dgvLISTA_TURNOS.DataSource = null;
                BindingSource source = new BindingSource();
                source.DataSource = LISTA_TURNOS_PROFESIONAL;
                dgvLISTA_TURNOS.DataSource = source;
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbFILTRO_DIA_LABORAL.Text))
            {
                MessageBox.Show("Debe seleccionar un dia laboral de la lista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_TURNOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oTURNO = (MODELO.TURNO)dgvLISTA_TURNOS.CurrentRow.DataBoundItem;

            ACCION = "M";

            frmTURNOS FORMULARIO_TURNO = frmTURNOS.OBTENER_INSTANCIA(oTURNO);
            FORMULARIO_TURNO.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_TURNOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oTURNO = (MODELO.TURNO)dgvLISTA_TURNOS.CurrentRow.DataBoundItem;
    
            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar el turno del paciente " + oTURNO.PACIENTE + " de la lista de turnos?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cTURNOS.ELIMINAR_TURNO(oTURNO);
                ARMA_GRILLA("A");
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            ACCION = "A";

            frmTURNOS FORMULARIO_TURNO = frmTURNOS.OBTENER_INSTANCIA();
            FORMULARIO_TURNO.Show();
            
        }
        public static void ARMAR_AL_AGREGAR()
        {
            frmLISTA_TURNOS_PROFESIONAL form = new frmLISTA_TURNOS_PROFESIONAL();

            form.ARMA_GRILLA("A");

        }

    }
}
