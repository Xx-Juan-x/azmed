using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        public static frmTURNOS OBTENER_INSTANCIA(MODELO.TURNO turno = null)
        {
            if (instancia == null)
            {
                instancia = new frmTURNOS(turno);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmTURNOS(turno);
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
        private double IMPORTE_CONSULTA;
        private double IMPORTE_ESTUDIO;
        private double PRECIO;
        public static string ACCION;
        public  int id_prof_modificar;
        public  string prof_modificar = null;
        public frmTURNOS(MODELO.TURNO turno = null)
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            cESPECIALIDAD = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();
            cPACIENTES = CONTROLADORA.PACIENTES.OBTENER_INSTANCIA();
            cPROFESIONALES = CONTROLADORA.PROFESIONALES.OBTENER_INSTANCIA();
            cATENCIONES = CONTROLADORA.ATENCIONES.OBTENER_INSTANCIA();
            cOBRAS_SOCIALES = CONTROLADORA.OBRAS_SOCIALES.OBTENER_INSTANCIA();
            cPLANES = CONTROLADORA.PLANES.OBTENER_INSTANCIA();

            //ESPECIALIDADES COMBOBOX
            ARMA_COMBOBOX_ESPECIALIDADES();

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
            if(turno != null)
            {
                modificar_turno(turno);
            }
        }
        //este metodo llena los datos desde el turno seleccionado desde la lISTAdeTurnos
        private void modificar_turno(MODELO.TURNO turno)
        {
            //Cuando prof_modificar es agregado desde aca , se sumara en el cmbProf AUTOMATICAMENTE
            prof_modificar = turno.PROFESIONAL.NOMBRE + " " + turno.PROFESIONAL.APELLIDO;
            id_prof_modificar = turno.PROFESIONAL.ID_PROFESIONAL;

            oTURNO = new MODELO.TURNO();
            oTURNO = (from a in cTURNOS.OBTENER_TURNOS() where a.ID_TURNO == turno.ID_TURNO select a).FirstOrDefault();
            cmbDIA.SelectedIndex = cmbDIA.FindString(turno.DIA);
            cmbESPECIALIDAD.SelectedIndex = cmbESPECIALIDAD.FindString(turno.ESPECIALIDAD.NOMBRE);
            cmbHORAS.SelectedIndex = cmbHORAS.FindString(turno.HORA_TURNO.ToString());
            if (cmbHORAS.SelectedIndex == -1)
            {
                cmbHORAS.Items.Add(turno.HORA_TURNO + " Hs");
                cmbHORAS.SelectedIndex = cmbHORAS.Items.Count - 1;
            }
            
            cmbPROFESIONAL.SelectedIndex = cmbPROFESIONAL.FindString(turno.PROFESIONAL.NOMBRE + " " + turno.PROFESIONAL.APELLIDO);
            if (cmbPROFESIONAL.SelectedIndex == -1)
            {
                cmbPROFESIONAL.SelectedIndex = cmbPROFESIONAL.Items.Count - 1;
            }
            cmbPACIENTE.SelectedIndex = cmbPACIENTE.FindString(turno.PACIENTE.NOMBRE + " " + turno.PACIENTE.APELLIDO);
            if(turno.TIPO == "CONSULTA")
            {
                rbCONSULTA.Checked = true;
            }
            else if(turno.TIPO == "ESTUDIO")
            {
                rbESTUDIO.Checked = true;
            }
            oTURNO.ID_TURNO = turno.ID_TURNO;

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

        //AGREGADO RECIENTEMENTE
        private void ARMA_COMBOBOX_ESPECIALIDADES()
        {
            cmbESPECIALIDAD.DataSource = null;
            cmbESPECIALIDAD.Items.Add("SELECCIONE...");
            cmbESPECIALIDAD.SelectedItem = "SELECCIONE...";

            cmbESPECIALIDAD.ValueMember = "ID_ESPECIALIDAD";
            cmbESPECIALIDAD.DisplayMember = "NOMBRE";
            cmbESPECIALIDAD.DataSource = cESPECIALIDAD.OBTENER_ESPECIALIDADES();
            
        }

        private void ARMA_COMBOBOX_PROFESIONALES(int ID_ESPECIALIDAD)
        {
            //Traigo todos los profesionales que coincidan con la especialidad y esten en un estado activo
            cmbPROFESIONAL.DataSource = null;
            var LISTA_PROFESIONALES = (from c in cPROFESIONALES.OBTENER_PROFESIONALES()
                                       where c.ESPECIALIDAD != null && c.ESPECIALIDAD.ID_ESPECIALIDAD == ID_ESPECIALIDAD && c.ESTADO != "INACTIVO"
                                       select c).ToList();

            cmbPROFESIONAL.DataSource = LISTA_PROFESIONALES;
            cmbPROFESIONAL.ValueMember = "ID_PROFESIONAL";
            cmbPROFESIONAL.DisplayMember = "NOMBRE" + "APELLIDO";
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

        private void cmbDIA_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //cmbPROFESIONAL.DataSource = null;
            
            int[] horas_habiles = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            int[] horas_no_habiles = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            DIAS DIA_SELECCIONADO = cmbDIA.SelectedItem as DIAS;

            string DIA_CMB_T = DIA_SELECCIONADO.DIA_TEXTO;//LUNES
            string DIA_CMB_V = DIA_SELECCIONADO.DIA_VALOR.ToShortDateString();//11-03-2022
            int[] hora_disponibles = new int[24];

            var LISTA_ATENCION = (from a in cATENCIONES.OBTENER_ATENCIONES().AsEnumerable()
                                  where a.ESPECIALIDAD.ID_ESPECIALIDAD == Convert.ToInt32(cmbESPECIALIDAD.SelectedValue)
                                  && a.PROFESIONAL.ID_PROFESIONAL == Convert.ToInt32(cmbPROFESIONAL.SelectedValue)
                                  && a.DIA_LABORAL == cmbDIA.SelectedValue.ToString() && a.ESTADO == "ACTIVO"
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
            
            /*var LISTA_TURNOS = (from b in cTURNOS.OBTENER_TURNOS().AsEnumerable()
                                where //b.ESPECIALIDAD.NOMBRE == cmbESPECIALIDAD.SelectedValue.ToString()
                                b.FECHA.ToShortDateString() == DIA_CMB_V
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
            }*/
        }

        private void cmbESPECIALIDAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID_ESPECIALIDAD = Convert.ToInt32(cmbESPECIALIDAD.SelectedValue);
            ARMA_COMBOBOX_PROFESIONALES(ID_ESPECIALIDAD);

            /*cmbHORAS.Items.Clear();
            cmbHORAS.ResetText();
            cmbPROFESIONAL.DataSource = null;
            MODELO.ESPECIALIDAD ESP = new MODELO.ESPECIALIDAD();
            ESP = (MODELO.ESPECIALIDAD)cmbESPECIALIDAD.SelectedValue;
            IMPORTE_CONSULTA = ESP.IMPORTE_CONSULTA;
            IMPORTE_ESTUDIO = ESP.IMPORTE_ESTUDIO;
            if (rbCONSULTA.Checked == true)
            {

                PRECIO = IMPORTE_CONSULTA;

            }
            if (rbESTUDIO.Checked == true)
            {

                PRECIO = IMPORTE_ESTUDIO;

            }*/
            return;
        }

        private void cmbHORAS_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cmbPROFESIONAL.DataSource = null;
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
            //Pasa cuando el turno es modificado
            COMBOBOX_PROFESIONAL cmb_extra = new COMBOBOX_PROFESIONAL(prof_modificar, id_prof_modificar);
            var prof_existe = LISTA_CMB_PROFESIONAL.Find(a => a.CMB_TEXTO == prof_modificar);
            if (prof_modificar != null && prof_existe == null)
            {
                LISTA_CMB_PROFESIONAL.Add(cmb_extra);
            }
            cmbPROFESIONAL.DataSource = LISTA_CMB_PROFESIONAL;*/
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
            //Si ya paso por el ModificarTurno
            if(oTURNO == null)
            {
                oTURNO = new MODELO.TURNO();

            }

            COMBOBOX_PROFESIONAL VALOR_PROFESIONAL = cmbPROFESIONAL.SelectedItem as COMBOBOX_PROFESIONAL;

            //BANDERA
            bool PLAN_INACTIVO = false;

            MODELO.PLAN SIN_PLAN = cPLANES.OBTENER_PLANES().Where(a => a.NOMBRE == "SIN ASIGNAR").FirstOrDefault();
            MODELO.OBRA_SOCIAL SIN_OBRA_SOCIAL = cOBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES().Where(a => a.NOMBRE == "SIN ASIGNAR").FirstOrDefault();
            if (Convert.ToInt32(cmbPACIENTE.SelectedValue) == -1) { 
                MessageBox.Show("Debe elegir un paciente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                oTURNO.PRECIO = (PRECIO) - (PRECIO * (oPACIENTE.PLAN.DESCUENTO_CONSULTA / 100));
            }
            else if (rbESTUDIO.Checked)
            {
                oTURNO.TIPO = rbESTUDIO.Text;
                oTURNO.TIPO = "ESTUDIO";
                oTURNO.PRECIO = (PRECIO) - (PRECIO * (oPACIENTE.PLAN.DESCUENTO_ESTUDIO / 100));
            }
            else
            {
                MessageBox.Show("Debe seleccionar si es un turno de tipo CONSULTA o un turno de tipo ESTUDIO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (frmLISTA_TURNOS_PROFESIONAL.ACCION == "A")
            {
                oTURNO.ESTADO = "SOLICITADO";
                cTURNOS.AGREGAR_TURNO(oTURNO);
                MessageBox.Show("Su " + oTURNO.TIPO + " se ah guardado con éxito", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbHORAS.Items.Clear();
                cmbHORAS.ResetText();
                cmbPROFESIONAL.DataSource = null;
                frmLISTA_TURNOS_PROFESIONAL FORMULARIO_TURNO = frmLISTA_TURNOS_PROFESIONAL.OBTENER_INSTANCIA();
                //frmLISTA_TURNOS_PROFESIONAL frm = new frmLISTA_TURNOS_PROFESIONAL();
                FORMULARIO_TURNO.ARMA_GRILLA("A");
            }
            else if (frmLISTA_TURNOS_PROFESIONAL.ACCION == "M")
            {
                
                cTURNOS.MODIFICAR_TURNO(oTURNO);
                MessageBox.Show(" Su " + oTURNO.TIPO + " se ah guardado con éxito", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbHORAS.Items.Clear();
                cmbHORAS.ResetText();
                cmbPROFESIONAL.DataSource = null;
                frmLISTA_TURNOS_PROFESIONAL FORMULARIO_TURNO = frmLISTA_TURNOS_PROFESIONAL.OBTENER_INSTANCIA();
                FORMULARIO_TURNO.ARMA_GRILLA("A");
                //frmLISTA_TURNOS_PROFESIONAL frm = new frmLISTA_TURNOS_PROFESIONAL();
                //frm.ARMA_GRILLA("A");
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
                PRECIO = IMPORTE_CONSULTA;
            }
        }

        private void rbESTUDIO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbESTUDIO.Checked == true)
            {
                PRECIO = IMPORTE_ESTUDIO;
            }
        }

        private void cmbPROFESIONAL_SelectedIndexChanged(object sender, EventArgs e)
        {
                var LISTA_DIAS_PROFESIONAL = (from c in cATENCIONES.OBTENER_ATENCIONES()
                                              where c.PROFESIONAL.ID_PROFESIONAL == Convert.ToInt32(cmbPROFESIONAL.SelectedValue)
                                              select c.DIA_LABORAL).ToList();

                /*List<string> LISTA_DIA = new List<string>();
                LISTA_DIA.Add("LUNES");
                LISTA_DIA.Add("MARTES");
                LISTA_DIA.Add("MIERCOLES");
                LISTA_DIA.Add("JUEVES");
                LISTA_DIA.Add("VIERNES");
                LISTA_DIA.Add("SABADO");
                LISTA_DIA.Add("DOMINGO");*/

                cmbDIA.DataSource = LISTA_DIAS_PROFESIONAL;
                //var DIAS_NO_AGREGADOS = LISTA_DIA.Except(LISTA_DIAS_PROFESIONAL).ToList();
                //cmbDIA.DataSource = DIAS_NO_AGREGADOS; 
        }
    } 
}
