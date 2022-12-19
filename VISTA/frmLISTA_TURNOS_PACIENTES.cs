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
    public partial class frmLISTA_TURNOS_PACIENTES : Form
    {
        private static frmLISTA_TURNOS_PACIENTES instancia;

        public static frmLISTA_TURNOS_PACIENTES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmLISTA_TURNOS_PACIENTES();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmLISTA_TURNOS_PACIENTES();
            }
            return instancia;
        }

        private CONTROLADORA.TURNOS cTURNOS;
        private CONTROLADORA.USUARIOS cUSUARIOS;       


        public frmLISTA_TURNOS_PACIENTES()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            rbLISTA_TURNOS_PROXIMOS.Checked = true;
            ARMA_GRILLA("B");
        }

        public void ARMA_GRILLA(string TIPO)
        {
            DateTime DIA_ACTUAL = DateTime.Now;
            //13:44:00
            string HORA_ACTUAL = Convert.ToString(DIA_ACTUAL.Hour);
            int HORA_ACTUAL_INT = Convert.ToInt32(HORA_ACTUAL);

            if (TIPO == "A")
            {
                if (rbLISTA_TURNOS_PASADO.Checked)
                {
                    var LISTA_TURNOS_PACIENTE = (from a in cTURNOS.OBTENER_TURNOS()
                                                 where a.PACIENTE.ID_USUARIO == frmLOGIN.ID_USUARIO
                                                 && (a.FECHA < DIA_ACTUAL)
                                                 || (a.FECHA == DIA_ACTUAL && a.HORA_TURNO < HORA_ACTUAL_INT)
                                                 select a).ToList();

                    dgvLISTA_TURNOS.DataSource = null;
                    dgvLISTA_TURNOS.DataSource = LISTA_TURNOS_PACIENTE;
                }
            }
            else if (TIPO == "B")
            {
                if (rbLISTA_TURNOS_PROXIMOS.Checked)
                {

                    var LISTA_TURNOS_PACIENTE = (from a in cTURNOS.OBTENER_TURNOS()
                                                 where a.PACIENTE.ID_USUARIO == frmLOGIN.ID_USUARIO
                                                 && (a.FECHA > DIA_ACTUAL)
                                                 || (a.FECHA == DIA_ACTUAL && a.HORA_TURNO > HORA_ACTUAL_INT)
                                                 select a).ToList();

                    dgvLISTA_TURNOS.DataSource = null;
                    dgvLISTA_TURNOS.DataSource = LISTA_TURNOS_PACIENTE;
                }
            }
        }

        private void rbLISTA_TURNOS_PASADO_CheckedChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA("A");
        }

        private void rbLISTA_TURNOS_PROXIMOS_CheckedChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA("B");
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
