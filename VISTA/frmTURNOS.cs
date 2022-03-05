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
    public partial class frmTURNOS : Form
    {
        private static frmTURNOS instancia;

        public static frmTURNOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmTURNOS();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmTURNOS();
            }
            return instancia;
        }

        private CONTROLADORA.TURNOS cTURNOS;
        private CONTROLADORA.USUARIOS cUSUARIOS;
        private MODELO.TURNO oTURNO;
        private CONTROLADORA.ESPECIALIDADES cESPECIALIDAD;
        private MODELO.ESPECIALIDAD oESPECIALIDAD;
        private CONTROLADORA.ATENCIONES cATENCIONES;
        private string DIA;

        public frmTURNOS()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            cESPECIALIDAD = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            cATENCIONES = CONTROLADORA.ATENCIONES.OBTENER_INSTANCIA();
            dgvLISTA_ATENCIONES.DataSource = cTURNOS.OBTENER_TURNOS();
            cmbESPECIALIDAD.DataSource = cESPECIALIDAD.OBTENER_ESPECIALIDADES();

            /*cmbDIA.Items.Add("SELECCIONE...");
            cmbDIA.SelectedItem = "SELECCIONE...";*/
            cmbDIA.Items.Add("LUNES");
            cmbDIA.Items.Add("MARTES");
            cmbDIA.Items.Add("MIERCOLES");
            cmbDIA.Items.Add("JUEVES");
            cmbDIA.Items.Add("VIERNES");
            cmbDIA.Items.Add("SABADO");
            cmbDIA.Items.Add("DOMINGO");


        }

        private void cmbDIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] horas_habiles = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            int[] horas_no_habiles = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            DIA = cmbDIA.SelectedItem.ToString();

            int[] hora_disponibles = new int[]{};           

            

            var LISTA_ATENCION = (from a in cATENCIONES.OBTENER_ATENCIONES().AsEnumerable()
                                  where a.ESPECIALIDAD.NOMBRE == cmbESPECIALIDAD.SelectedValue.ToString()
                                  && a.DIA_LABORAL == DIA
                                  select a).ToList();
            foreach (var lista in LISTA_ATENCION)
            {               
                int[] HORA_ARRAY_PROFESIONAL = Enumerable.Range(lista.HORA_INICIO, lista.HORA_FIN - lista.HORA_INICIO + 1).ToArray();
               
                hora_disponibles = hora_disponibles.Concat(HORA_ARRAY_PROFESIONAL).ToArray();
            }

            //5,6,7,8,... 19,20

            horas_no_habiles = horas_no_habiles.Except(hora_disponibles).ToArray();
            horas_habiles = hora_disponibles;
            cmbHORAS.Items.Clear();
            cmbHORAS.ResetText();
            //la hora 5 hasta la 24

            for (int i = 5; i < 25; i++)
            {
                if (horas_no_habiles.Contains(i))
                {
                    //CELDA INHABILITADA
                    //cmbHORAS.Items.Add(new ComboBoxItem() { Selectable = false, Text = i.ToString(), Value = -1 });
                }
                else if (horas_habiles.Contains(i))
                {
                    //cmbHORAS.Items.Add(new ComboBoxItem() { Selectable = true, Text = i.ToString(), Value = i });
                    cmbHORAS.Items.Add(i.ToString()+" Hs");//7Hs 7
                }
            }
        }

        private class ComboBoxItem
        {
            public int Value { get; set; }
            public string Text { get; set; }
            public bool Selectable { get; set; }
        }
    }
    
}
