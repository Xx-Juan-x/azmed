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
    public partial class frmCLINICA : Form
    {
        public frmCLINICA()
        {
            InitializeComponent();
        }

        private void registrarEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LLAMO A MI FORMULARIO ESPECIALIDAD A PARTIR DEL PATRON SINGLETON
            frmESPECIALIDAD FORMULARIO_ESPECIALIDAD = frmESPECIALIDAD.OBTENER_INSTANCIA();
            // FUNCION PARA MOSTRAR EL FORMULARIO
            FORMULARIO_ESPECIALIDAD.Show();
        }

        private void registrarObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmOBRA_SOCIAL FORMULARIO_OBRA_SOCIAL = frmOBRA_SOCIAL.OBTENER_INSTANCIA();
            FORMULARIO_OBRA_SOCIAL.Show();
        }
    }
}
