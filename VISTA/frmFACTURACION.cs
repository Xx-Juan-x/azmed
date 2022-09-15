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
    public partial class frmFACTURACION_TURNOS : Form
    {
        private static frmFACTURACION_TURNOS instancia;

        public static frmFACTURACION_TURNOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmFACTURACION_TURNOS();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmFACTURACION_TURNOS();
            }
            return instancia;
        }

        private CONTROLADORA.TURNOS cTURNOS;
        private CONTROLADORA.USUARIOS cUSUARIOS;
        private MODELO.TURNO oTURNO;

        public frmFACTURACION_TURNOS()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            DateTime DIA_ACTUAL = DateTime.Now;

            var LISTA_TURNOS_HOY_FACTURAR = (from a in cTURNOS.OBTENER_TURNOS()
                                             where (a.FECHA.Date == DIA_ACTUAL.Date)
                                             select a).ToList();

            dgvLISTA_TURNOS_HOY_FACTURAR.DataSource = null;
            dgvLISTA_TURNOS_HOY_FACTURAR.DataSource = LISTA_TURNOS_HOY_FACTURAR;

        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
