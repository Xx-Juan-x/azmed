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
    public partial class frmUSUARIOS : Form
    {
        public frmUSUARIOS()
        {
            InitializeComponent();
            cmbROL.Items.AddRange(new object[] {
            "JEFE DE COMPRAS",
            "PROFESIONAL",
            "ADMINISTRADOR"});
        }
    }
}
