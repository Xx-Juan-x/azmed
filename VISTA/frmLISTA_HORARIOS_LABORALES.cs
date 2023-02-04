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
    public partial class frmLISTA_HORARIOS_LABORALES : Form
    {
        //PATRON SINGLETON
        private static frmLISTA_HORARIOS_LABORALES instancia;

        public static frmLISTA_HORARIOS_LABORALES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmLISTA_HORARIOS_LABORALES();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmLISTA_HORARIOS_LABORALES();
            }
            return instancia;
        }

        private CONTROLADORA.ATENCIONES cATENCIONES;

        public frmLISTA_HORARIOS_LABORALES()
        {
            InitializeComponent();
            cATENCIONES = CONTROLADORA.ATENCIONES.OBTENER_INSTANCIA();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_HORARIOS_LABORALES.DataSource = null;
           
            //VER: DEBERÍA VERSE LOS HORARIOS LABORALES DE LOS USUARIOS PROFESIONALES QUE INGRESARON Y NO DE TODOS LOS PROFESIONALES
            var LISTA_HORARIOS_LABORALES = (from a in cATENCIONES.OBTENER_ATENCIONES()
                                        where a.PROFESIONAL.ID_PROFESIONAL == frmLOGIN.ID_USUARIO
                                        select a).ToList();

            dgvLISTA_HORARIOS_LABORALES.DataSource = LISTA_HORARIOS_LABORALES;

            dgvLISTA_HORARIOS_LABORALES.AutoGenerateColumns = false;
            
            if (dgvLISTA_HORARIOS_LABORALES.Columns.Contains("ID_ATENCION") && dgvLISTA_HORARIOS_LABORALES.Columns.Contains("ESPECIALIDAD") && dgvLISTA_HORARIOS_LABORALES.Columns.Contains("PROFESIONAL"))
            {
                dgvLISTA_HORARIOS_LABORALES.Columns.Remove("ID_ATENCION");
                dgvLISTA_HORARIOS_LABORALES.Columns.Remove("ESPECIALIDAD");
                dgvLISTA_HORARIOS_LABORALES.Columns.Remove("PROFESIONAL");
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
