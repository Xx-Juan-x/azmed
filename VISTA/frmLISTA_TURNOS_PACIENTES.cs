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
        public class Facade
        {
            ARMAR_GRILLA_A one;
            ARMAR_GRILLA_B two;
            public Facade()
            {
                one = new ARMAR_GRILLA_A { };
                two = new ARMAR_GRILLA_B { };
            }
            public dynamic METODO_A()
            {
                return one.MOSTRAR();
            }
            public dynamic METODO_B()
            {
                return two.MOSTRAR();
            }
        }
        public class ARMAR_GRILLA_A
        {
            protected CONTROLADORA.TURNOS cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            protected CONTROLADORA.USUARIOS cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            protected DateTime DIA_ACTUAL = DateTime.Now;
            protected int HORA_ACTUAL_INT = Convert.ToInt32(Convert.ToString(DateTime.Now.Hour));
            public dynamic MOSTRAR()
            {
                var LISTA_TURNOS_PACIENTE = (from a in cTURNOS.OBTENER_TURNOS()
                                             where a.PACIENTE.ID_USUARIO == frmLOGIN.ID_USUARIO
                                             && (a.FECHA < DIA_ACTUAL)
                                             || (a.FECHA == DIA_ACTUAL && a.HORA_TURNO < HORA_ACTUAL_INT)
                                             select a).ToList();
                return LISTA_TURNOS_PACIENTE;

            }
        }
        public class ARMAR_GRILLA_B
        {
            protected CONTROLADORA.TURNOS cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            protected CONTROLADORA.USUARIOS cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            protected DateTime DIA_ACTUAL = DateTime.Now;
            protected int HORA_ACTUAL_INT = Convert.ToInt32(Convert.ToString(DateTime.Now.Hour));
            public dynamic MOSTRAR()
            {
                var LISTA_TURNOS_PACIENTE = (from a in cTURNOS.OBTENER_TURNOS()
                                             where a.PACIENTE.ID_USUARIO == frmLOGIN.ID_USUARIO
                                             && (a.FECHA > DIA_ACTUAL)
                                             || (a.FECHA == DIA_ACTUAL && a.HORA_TURNO > HORA_ACTUAL_INT)
                                             select a).ToList();
                return LISTA_TURNOS_PACIENTE;

            }
        }

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
        private frmLISTA_TURNOS_PACIENTES()
        {
            InitializeComponent();
            rbLISTA_TURNOS_PROXIMOS.Checked = true;
            ARMA_GRILLA("B");
        }
        
        public void ARMA_GRILLA(string TIPO)
        {
            if (TIPO == "A")
            {
                if (rbLISTA_TURNOS_PASADO.Checked)
                {
                    Facade facade = new Facade();
                    dgvLISTA_TURNOS.DataSource = null;
                    dgvLISTA_TURNOS.DataSource = facade.METODO_A();

                }
            }
            else if (TIPO == "B")
            {
                if (rbLISTA_TURNOS_PROXIMOS.Checked)
                {
                    Facade facade = new Facade();
                    dgvLISTA_TURNOS.DataSource = null;
                    dgvLISTA_TURNOS.DataSource = facade.METODO_B();
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
