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
    public partial class frmTURNOS_CONSULTA : Form
    {
        private static frmTURNOS_CONSULTA instancia;

        public static frmTURNOS_CONSULTA OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmTURNOS_CONSULTA();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmTURNOS_CONSULTA();
            }
            return instancia;
        }

        private CONTROLADORA.TURNOS cTURNOS;
        private CONTROLADORA.USUARIOS cUSUARIOS;
        private MODELO.TURNO oTURNO;

        public frmTURNOS_CONSULTA()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            dgvLISTA_ATENCIONES.DataSource = cUSUARIOS.OBTENER_USUARIOS();
        }

        

    }
}
