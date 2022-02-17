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
    public partial class frmASIGNAR_ESPECIALIDAD : Form
    {
        private CONTROLADORA.USUARIOS cUSUARIOS;
        public frmASIGNAR_ESPECIALIDAD()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            //dgvLISTA_PROFESIONALES.DataSource = cUSUARIOS.OBTENER_USUARIOS();

            dgvLISTA_PROFESIONALES.DataSource = cUSUARIOS.OBTENER_PROFESIONALES();
        }

        /*private bool OBTENER_PROFESIONAL()
        {
            var RESPUESTA = from d in cUSUARIOS.OBTENER_PROFESIONALES()
                            where d.TIPO == "PROFESIONAL"
                            select d;
       
            //string PROFESIONAL = "";

            if (RESPUESTA.Any())
            {
                RESPUESTA.ToList().ForEach(s => dgvLISTA_PROFESIONALES.DataSource = s.TIPO);
                //dgvLISTA_PROFESIONALES.DataSource = null;
                //dgvLISTA_PROFESIONALES.DataSource = RESPUESTA;
                return true;
            }
            else
            {
                return false;
            }
        }*/



    }
}
