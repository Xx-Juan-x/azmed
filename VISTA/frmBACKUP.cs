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
    public partial class frmBACKUP : Form
    {
        private static frmBACKUP instancia;

        public static frmBACKUP OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmBACKUP();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmBACKUP();
            }
            return instancia;
        }

        public frmBACKUP()
        {
            InitializeComponent();
        }



    }
}
