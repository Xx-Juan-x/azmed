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


        public frmLISTA_TURNOS_PROFESIONAL()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_TURNOS.DataSource = null;
            



            var LISTA_TURNOS_PROFESIONAL = (from a in cTURNOS.OBTENER_TURNOS()
                                            where a.PROFESIONAL.ID_USUARIO == frmLOGIN.ID_USUARIO
                                            select a).ToList();

            dgvLISTA_TURNOS.DataSource = LISTA_TURNOS_PROFESIONAL;


            /*var LISTA_TURNOS_PROFESIONAL = (from a in cTURNOS.OBTENER_TURNOS()
                                            where a.PROFESIONAL.ID_USUARIO == frmLOGIN.ID_USUARIO
                                            && a.DIA == cmbFILTRO_DIA_LABORAL.SelectedValue
                                            select a).ToList();*/          
        }



    }
}
