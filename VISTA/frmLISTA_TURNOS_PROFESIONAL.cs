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
        private CONTROLADORA.USUARIOS cUSUARIOS;        

        public frmLISTA_TURNOS_PROFESIONAL()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();

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
        }

        private void ARMA_GRILLA(string TIPO)
        {
            var LISTA_TURNOS_PROFESIONAL = (from a in cTURNOS.OBTENER_TURNOS()
                                            where a.PROFESIONAL.ID_USUARIO == frmLOGIN.ID_USUARIO
                                            select a).ToList();
            
            if (TIPO == "A")
            {
                dgvLISTA_TURNOS.DataSource = null;
                dgvLISTA_TURNOS.DataSource = LISTA_TURNOS_PROFESIONAL;
            }
            if (TIPO == "B")
            {
                string FILTRO_DIA_LABORAL = cmbFILTRO_DIA_LABORAL.Text;

                if (FILTRO_DIA_LABORAL == "TODOS")
                {
                    dgvLISTA_TURNOS.DataSource = null;
                    dgvLISTA_TURNOS.DataSource = LISTA_TURNOS_PROFESIONAL;
                }
                else
                {
                    var LISTA_TURNOS = (from a in cTURNOS.OBTENER_TURNOS()
                                        where a.DIA == FILTRO_DIA_LABORAL &&
                                        a.PROFESIONAL.ID_USUARIO == frmLOGIN.ID_USUARIO
                                        select a).ToList();

                    dgvLISTA_TURNOS.DataSource = null;
                    dgvLISTA_TURNOS.DataSource = LISTA_TURNOS;
                }
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
    }
}
