using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        private CONTROLADORA.PACIENTES cPACIENTES;
        private CONTROLADORA.PROFESIONALES cPROFESIONALES;
        private MODELO.TURNO oTURNO;
        private CONTROLADORA.ESPECIALIDADES cESPECIALIDAD;
        private MODELO.ESPECIALIDAD oESPECIALIDAD;
        private MODELO.OBRA_SOCIAL oOBRA_SOCIAL;
        private MODELO.PLAN oPLAN;
        private MODELO.PACIENTE oPACIENTE;
        private MODELO.PROFESIONAL oPROFESIONAL;
        private CONTROLADORA.ATENCIONES cATENCIONES;
        private CONTROLADORA.OBRAS_SOCIALES cOBRAS_SOCIALES;
        private CONTROLADORA.PLANES cPLANES;
        private string DIA;
        private string ACCION;
        private double IMPORTE_CONSULTA;
        private double IMPORTE_ESTUDIO;

        public frmTURNOS()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            cESPECIALIDAD = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();
            cPACIENTES = CONTROLADORA.PACIENTES.OBTENER_INSTANCIA();
            cPROFESIONALES = CONTROLADORA.PROFESIONALES.OBTENER_INSTANCIA();
            cATENCIONES = CONTROLADORA.ATENCIONES.OBTENER_INSTANCIA();
            cOBRAS_SOCIALES = CONTROLADORA.OBRAS_SOCIALES.OBTENER_INSTANCIA();
            cPLANES = CONTROLADORA.PLANES.OBTENER_INSTANCIA();
            cmbESPECIALIDAD.DataSource = cESPECIALIDAD.OBTENER_ESPECIALIDADES();
            txtPRECIO.Enabled = false;
            var lista_pacientes = cPACIENTES.OBTENER_PACIENTES().ToList();
            List<COMBOBOX_PACIENTE> LISTA_CMB_PACIENTES = new List<COMBOBOX_PACIENTE>();
            LISTA_CMB_PACIENTES.Add(new COMBOBOX_PACIENTE("SELECCIONE...", -1));
            cmbPACIENTE.DisplayMember = "CMB_TEXTO";
            cmbPACIENTE.ValueMember = "CMB_VALOR";
            foreach (var PACIENTE in lista_pacientes)
            {
                LISTA_CMB_PACIENTES.Add(new COMBOBOX_PACIENTE(PACIENTE.NOMBRE + " " + PACIENTE.APELLIDO, PACIENTE.ID_PACIENTE));
            }
            cmbPACIENTE.DataSource = LISTA_CMB_PACIENTES;
            /*cmbDIA.Items.Add("SELECCIONE...");
            cmbDIA.SelectedItem = "SELECCIONE...";*/
            var hoy = DateTime.Today;//2022-03-07

            var dia_nombre = new string[7];
            dia_nombre[0] = traducir_dia(hoy.DayOfWeek.ToString());//VIERNES 
            dia_nombre[1] = traducir_dia(hoy.AddDays(1).DayOfWeek.ToString());//SABADO
            dia_nombre[2] = traducir_dia(hoy.AddDays(2).DayOfWeek.ToString());
            dia_nombre[3] = traducir_dia(hoy.AddDays(3).DayOfWeek.ToString());
            dia_nombre[4] = traducir_dia(hoy.AddDays(4).DayOfWeek.ToString());
            dia_nombre[5] = traducir_dia(hoy.AddDays(5).DayOfWeek.ToString());
            dia_nombre[6] = traducir_dia(hoy.AddDays(6).DayOfWeek.ToString());

            var dia_fecha = new DateTime[7];
            dia_fecha[0] = hoy;//2022-03-11 
            dia_fecha[1] = hoy.AddDays(1);//2022-03-12
            dia_fecha[2] = hoy.AddDays(2);
            dia_fecha[3] = hoy.AddDays(3);
            dia_fecha[4] = hoy.AddDays(4);
            dia_fecha[5] = hoy.AddDays(5);
            dia_fecha[6] = hoy.AddDays(6);

            List<DIAS> LISTA_DIAS = new List<DIAS>();
            for (int i = 0; i < 7; i++)
            {
                LISTA_DIAS.Add(new DIAS(dia_nombre[i], dia_fecha[i]));
            }
            cmbDIA.DataSource = LISTA_DIAS;
            cmbDIA.DisplayMember = "DIA_TEXTO";
            cmbDIA.ValueMember = "DIA_VALOR";

            //cmbDIA.SelectionChanged += new SelectionChangedEventHandler(comboBox1_SelectionChanged);

            for (int i = 0; i < 7; i++)
            {
                //cmbDIA.Items.Add(new ComboboxItem() { Text = dia_nombre[i], Value = dia_fecha[i] });
                // cmbDIA.Items.Insert(dia_fecha[i], dia_nombre[i]);
            }

        }

        private string traducir_dia(string dia)
        {
            switch (dia)
            {
                case "Monday":
                    dia = "LUNES";
                    break;
                case "Tuesday":
                    dia = "MARTES";
                    break;
                case "Wednesday":
                    dia = "MIERCOLES";
                    break;
                case "Thursday":
                    dia = "JUEVES";
                    break;
                case "Friday":
                    dia = "VIERNES";
                    break;
                case "Saturday":
                    dia = "SABADO";
                    break;
                case "Sunday":
                    dia = "DOMINGO";
                    break;
            }
            return dia;
        }

        class DIAS
        {
            public string DIA_TEXTO { get; set; }
            public DateTime DIA_VALOR { get; set; }
            public DIAS(string T, DateTime V)
            {
                DIA_VALOR = V;
                DIA_TEXTO = T;
            }
        }


        /*public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }*/

        private void cmbDIA_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbPROFESIONAL.DataSource = null;
            int[] horas_habiles = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            int[] horas_no_habiles = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            DIAS DIA_SELECCIONADO = cmbDIA.SelectedItem as DIAS;

            string DIA_CMB_T = DIA_SELECCIONADO.DIA_TEXTO;//LUNES
            string DIA_CMB_V = DIA_SELECCIONADO.DIA_VALOR.ToShortDateString();//11-03-2022
            int[] hora_disponibles = new int[24];

            var LISTA_ATENCION = (from a in cATENCIONES.OBTENER_ATENCIONES().AsEnumerable()
                                  where a.ESPECIALIDAD.NOMBRE == cmbESPECIALIDAD.SelectedValue.ToString()
                                  && a.DIA_LABORAL == DIA_CMB_T
                                  select a).ToList();

            var dict = new Dictionary<int, int>();
            foreach (var lista in LISTA_ATENCION)
            {
                int[] HORA_ARRAY_PROFESIONAL = Enumerable.Range(lista.HORA_INICIO, lista.HORA_FIN - lista.HORA_INICIO + 1).ToArray();
                for (int i = 0; i < HORA_ARRAY_PROFESIONAL.Length; i++)
                {
                    if (Array.IndexOf(dict.Keys.ToArray(), HORA_ARRAY_PROFESIONAL[i]) != -1)
                    {
                        dict[HORA_ARRAY_PROFESIONAL[i]] = dict[HORA_ARRAY_PROFESIONAL[i]] + 1;
                    }
                    else
                    {
                        dict.Add(HORA_ARRAY_PROFESIONAL[i], 1);
                    }
                }
                //hora_disponibles = hora_disponibles.Concat(HORA_ARRAY_PROFESIONAL).ToArray();
            }
            //La LISTA_TURNOS es un array [5,6,7...] con los turnos asignados  
            var LISTA_TURNOS = (from b in cTURNOS.OBTENER_TURNOS().AsEnumerable()
                                where b.ESPECIALIDAD.NOMBRE == cmbESPECIALIDAD.SelectedValue.ToString()
                                && b.FECHA.ToShortDateString() == DIA_CMB_V
                                select b.HORA_TURNO).ToArray();
            for (int i = 0; i < LISTA_TURNOS.Length; i++)
            {
                if (Array.IndexOf(dict.Keys.ToArray(), LISTA_TURNOS[i]) != -1)
                {
                    //dict[HORA_ARRAY_PROFESIONAL[i]] = dict[HORA_ARRAY_PROFESIONAL[i]] + 1;
                    dict[LISTA_TURNOS[i]] = dict[LISTA_TURNOS[i]] - 1;
                }
            }
            int index = 0;

            foreach (var keyval in dict)
            {
                if (keyval.Value > 0)
                {
                    hora_disponibles[index] = keyval.Key;
                    index++;
                }
            }


            //Borramos el array de horas disponibles  exceptuando lo que LISTA_TURNOS TIENE 

            //horas_disponibles[5,6,7,8,9,10]
            //LISTA_TURNOS[5,6]
            //RESULTADO: hora_disponibles [7,8,9,10]

            //hora_disponibles = hora_disponibles.Except(LISTA_TURNOS).ToArray();

            horas_no_habiles = horas_no_habiles.Except(hora_disponibles).ToArray();
            horas_habiles = hora_disponibles;
            cmbHORAS.Items.Clear();
            cmbHORAS.ResetText();


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
                    cmbHORAS.Items.Add(i.ToString() + " Hs");//7Hs 7
                }
            }
        }

        private void cmbESPECIALIDAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHORAS.Items.Clear();
            cmbHORAS.ResetText();
            cmbPROFESIONAL.DataSource = null;
            //cmbESPECIALIDAD.SelectedValue;
            MODELO.ESPECIALIDAD ESP = new MODELO.ESPECIALIDAD();
            ESP = (MODELO.ESPECIALIDAD)cmbESPECIALIDAD.SelectedValue;
            IMPORTE_CONSULTA = ESP.IMPORTE_CONSULTA;
            IMPORTE_ESTUDIO = ESP.IMPORTE_ESTUDIO;
            txtPRECIO.Text = null;
            rbCONSULTA.Checked = false;
            rbESTUDIO.Checked = false;
        }

        private void cmbHORAS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPROFESIONAL.DataSource = null;
            DIAS dia = cmbDIA.SelectedItem as DIAS;
            string HORA_TEXTO = (string)cmbHORAS.SelectedItem.ToString().Replace(" Hs", "");
            //Traigo todos los profesionales que coincidan con , el dia laboral, con la especialidad seleccionada, y con la hora selecciona
            //MessageBox.Show(cmbHORAS.SelectedItem.ToString());
            var LISTA_PROFESIONALES = (from a in cATENCIONES.OBTENER_ATENCIONES()
                                       where a.DIA_LABORAL == dia.DIA_TEXTO
                                       && a.ESPECIALIDAD.NOMBRE == cmbESPECIALIDAD.SelectedValue.ToString()
                                       && (a.HORA_INICIO <= Convert.ToInt32(HORA_TEXTO)
                                       && a.HORA_FIN >= Convert.ToInt32(HORA_TEXTO))
                                       select a).ToList();

            //En esta lista le inserto un indice por cada profesional que esta disponible luego de recorrer los turnos de dicho profesional.
            List<COMBOBOX_PROFESIONAL> LISTA_CMB_PROFESIONAL = new List<COMBOBOX_PROFESIONAL>();

            cmbPROFESIONAL.DisplayMember = "CMB_TEXTO";
            cmbPROFESIONAL.ValueMember = "CMB_VALOR";
           
            int HORA_NUMERO = Convert.ToInt32(HORA_TEXTO);
            foreach (var PROFESIONAL in LISTA_PROFESIONALES)
            {
                var COMPROBAR_PROFESIONAL = (from b in cTURNOS.OBTENER_TURNOS().AsEnumerable()
                                             where b.HORA_TURNO == HORA_NUMERO
                                             && b.PROFESIONAL.ID_PROFESIONAL == PROFESIONAL.PROFESIONAL.ID_PROFESIONAL
                                             && b.FECHA.ToShortDateString() == dia.DIA_VALOR.ToShortDateString()
                                             select b).Count();
                //si COMPROBAR_PROFESIONAL el count me devuelve 0, significa que el profesional esta disponible
                //si devuelve 1 , el profesional ya tiene un turno para esa hora, no esta disponible
                if (COMPROBAR_PROFESIONAL == 0)
                {
                    //agrego a la cmb 
                    LISTA_CMB_PROFESIONAL.Add(new COMBOBOX_PROFESIONAL(PROFESIONAL.PROFESIONAL.NOMBRE + " " + PROFESIONAL.PROFESIONAL.APELLIDO, PROFESIONAL.PROFESIONAL.ID_PROFESIONAL));
                }
            }
            cmbPROFESIONAL.DataSource = LISTA_CMB_PROFESIONAL;
        }

        class COMBOBOX_PROFESIONAL
        {
            public string CMB_TEXTO { get; set; }
            public int CMB_VALOR { get; set; }//11
            public COMBOBOX_PROFESIONAL(string T, int V)
            {
                CMB_TEXTO = T;
                CMB_VALOR = V;
            }
        }
        class COMBOBOX_PACIENTE
        {
            public string CMB_TEXTO { get; set; }
            public int CMB_VALOR { get; set; }
            public COMBOBOX_PACIENTE(string T, int V)
            {
                CMB_TEXTO = T;
                CMB_VALOR = V;
            }
        }


        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (cmbESPECIALIDAD.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad para poder registrar un turno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDIA.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un día de la semana para poder registrar un turno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbHORAS.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una hora de los que trabaja el profesional para poder registrar un turno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPROFESIONAL.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el profesional que se encuentra disponible para poder registrar un turno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPACIENTE.SelectedItem == "SELECCIONE...")
            {
                MessageBox.Show("Debe seleccionar un paciente que se encuentra disponible para poder registrar un turno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            oTURNO = new MODELO.TURNO();

            COMBOBOX_PROFESIONAL VALOR_PROFESIONAL = cmbPROFESIONAL.SelectedItem as COMBOBOX_PROFESIONAL;

            //BANDERA
            bool PLAN_INACTIVO = false;

            MODELO.PLAN SIN_PLAN = cPLANES.OBTENER_PLANES().Where(a => a.NOMBRE == "SIN ASIGNAR").FirstOrDefault();
            MODELO.OBRA_SOCIAL SIN_OBRA_SOCIAL = cOBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES().Where(a => a.NOMBRE == "SIN ASIGNAR").FirstOrDefault();

            var PACIENTE = (from a in cPACIENTES.OBTENER_PACIENTES()
                            where a.ID_PACIENTE == Convert.ToInt32(cmbPACIENTE.SelectedValue)
                            select a).ToList();
 
            if (PACIENTE[0].PLAN.ESTADO == "INACTIVO")
            {
                DialogResult RESPUESTA = MessageBox.Show("El plan asignado a la cuenta actual ha sido deshabilitada, usted solicitará el turno sin poseer plan ni obra social.", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (RESPUESTA == DialogResult.No)
                {
                    MessageBox.Show("Verifique los datos del plan y la obra social", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    PLAN_INACTIVO = true;
                }
            }

            var PROFESIONAL = (from a in cPROFESIONALES.OBTENER_PROFESIONALES()
                               where a.ID_PROFESIONAL == VALOR_PROFESIONAL.CMB_VALOR
                               select a).ToList();
            foreach (var PROFESIONALES in PROFESIONAL)
            {
                oPROFESIONAL = PROFESIONALES;
            }
            foreach (var PACIENTES in PACIENTE)
            {

                oOBRA_SOCIAL = (PLAN_INACTIVO ? SIN_OBRA_SOCIAL : PACIENTES.OBRA_SOCIAL);
                oPLAN = (PLAN_INACTIVO ? SIN_PLAN : PACIENTES.PLAN);
                oPACIENTE = PACIENTES;
            }
            DIAS DIA_SELECCIONADO = cmbDIA.SelectedItem as DIAS;

            // ASIGNO MIS COMBO BOXS CON MIS PROPIEDADES
            ACCION = "A";
            oTURNO.ESPECIALIDAD = (MODELO.ESPECIALIDAD)cmbESPECIALIDAD.SelectedItem;
            oTURNO.DIA = cmbDIA.Text;
            string HORA_TEXTO = (string)cmbHORAS.SelectedItem.ToString().Replace(" Hs", "");
            oTURNO.HORA_TURNO = Convert.ToInt32(HORA_TEXTO);
            oPROFESIONAL.ID_PROFESIONAL = VALOR_PROFESIONAL.CMB_VALOR;
            oTURNO.PROFESIONAL = oPROFESIONAL;
            oTURNO.FECHA = DIA_SELECCIONADO.DIA_VALOR;
            oTURNO.PACIENTE = oPACIENTE; 
            if (rbCONSULTA.Checked)
            {
                oTURNO.TIPO = rbCONSULTA.Text;
                oTURNO.TIPO = "CONSULTA";
            }
            else if (rbESTUDIO.Checked)
            {
                oTURNO.TIPO = rbESTUDIO.Text;
                oTURNO.TIPO = "ESTUDIO";
            }
            else
            {
                MessageBox.Show("Debe seleccionar si es un turno de tipo CONSULTA o un turno de tipo ESTUDIO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double PRECIO;
            PRECIO = Convert.ToDouble(txtPRECIO.Text);
            oTURNO.PRECIO = PRECIO;
            oTURNO.ESTADO = "SOLICITADO";

            //Vacío la texbox
            txtPRECIO.Text = null;

            if (ACCION == "A")
            {
                cTURNOS.AGREGAR_TURNO(oTURNO);
                MessageBox.Show("Su " + oTURNO.TIPO + " se ah guardado con éxito", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbHORAS.Items.Clear();
                cmbHORAS.ResetText();
                cmbPROFESIONAL.DataSource = null;
            }
            else if (ACCION == "M")
            {
                cmbESPECIALIDAD.Text = oTURNO.ESPECIALIDAD.ToString();
                cmbDIA.Text = oTURNO.DIA.ToString();
                cmbHORAS.Text = oTURNO.HORA_TURNO.ToString();
                cmbPROFESIONAL.Text = oTURNO.PROFESIONAL.ToString();
                cmbPACIENTE.Text = oTURNO.PACIENTE.ToString();

                if (rbCONSULTA.Checked)
                {
                    oTURNO.TIPO = rbCONSULTA.Text;
                    oTURNO.TIPO = "CONSULTA";
                }
                else if (rbESTUDIO.Checked)
                {
                    oTURNO.TIPO = rbESTUDIO.Text;
                    oTURNO.TIPO = "ESTUDIO";
                }
                else
                {
                    MessageBox.Show("Debe seleccionar si es un turno de tipo CONSULTA o un turno de tipo ESTUDIO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtPRECIO.Text = oTURNO.PRECIO.ToString();

                cTURNOS.MODIFICAR_TURNO(oTURNO);
                frmLISTA_TURNOS_PROFESIONAL FORMULARIO_LISTA_TURNO = frmLISTA_TURNOS_PROFESIONAL.OBTENER_INSTANCIA();
                FORMULARIO_LISTA_TURNO.Show();
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {           
            this.Close();
        }


        private void rbCONSULTA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCONSULTA.Checked == true)
            {
                double PRECIO = 0;
                PRECIO = IMPORTE_CONSULTA /*- (IMPORTE_CONSULTA * (frmLOGIN.DESCUENTO_CONSULTA* / 100))*/;
                txtPRECIO.Text = PRECIO.ToString();
            }
        }

        private void rbESTUDIO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbESTUDIO.Checked == true)
            {
                double PRECIO = 0;
                PRECIO = IMPORTE_ESTUDIO /*- (IMPORTE_ESTUDIO * (frmLOGIN.DESCUENTO_ESTUDIO / 100))*/;
                txtPRECIO.Text = PRECIO.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}
