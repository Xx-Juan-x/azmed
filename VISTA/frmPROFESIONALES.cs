using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmPROFESIONALES : Form
    {
        //PATRON SINGLETON
        private static frmPROFESIONALES instancia;

        public static frmPROFESIONALES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmPROFESIONALES();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmPROFESIONALES();
            }
            return instancia;
        }

        private CONTROLADORA.PROFESIONALES cPROFESIONALES;
        private MODELO.PROFESIONAL oPROFESIONAL;
        private CONTROLADORA.ESPECIALIDADES cESPECIALIDADES;
        private MODELO.TURNO oTURNO;
        private CONTROLADORA.TURNOS cTURNOS;
        private CONTROLADORA.ATENCIONES cATENCIONES;
        private MODELO.ATENCION oATENCION;
        string ACCION;

        public frmPROFESIONALES()
        {
            InitializeComponent();
            cPROFESIONALES = CONTROLADORA.PROFESIONALES.OBTENER_INSTANCIA();
            cESPECIALIDADES = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();

            ARMA_COMBOBOX_ESPECIALIDAD();
            ARMA_GRILLA("A");
            MODO_GRILLA();
        }

        private void ARMA_GRILLA(string TIPO)
        {
            if (TIPO == "A")
            {
                dgvLISTA_PROFESIONALES.DataSource = null;
                dgvLISTA_PROFESIONALES.DataSource = cPROFESIONALES.OBTENER_PROFESIONALES();

                List<MODELO.ESPECIALIDAD> especialidades = cESPECIALIDADES.OBTENER_ESPECIALIDADES();
                MODELO.ESPECIALIDAD especial = new MODELO.ESPECIALIDAD();
                especial.NOMBRE = "TODOS";
                especial.ID_ESPECIALIDAD = 0;

                especialidades.Insert(0,especial);
                cmbFILTRO_ESPECIALIDAD.DataSource = especialidades;


            }
            if (TIPO == "B")
            {
                string FILTRO_PROFESIONAL = cmbFILTRO_ESPECIALIDAD.Text;

                if (FILTRO_PROFESIONAL == "TODOS")
                {
                    dgvLISTA_PROFESIONALES.DataSource = null;
                    dgvLISTA_PROFESIONALES.DataSource = cPROFESIONALES.OBTENER_PROFESIONALES();

                }
                else
                {
                    var FILTRO_ESPECIALIDAD_PROFESIONAL = (from a in cPROFESIONALES.OBTENER_PROFESIONALES()
                                                       where a.ESPECIALIDAD.NOMBRE == FILTRO_PROFESIONAL
                                                       select a).ToList();

                    dgvLISTA_PROFESIONALES.DataSource = null;
                    dgvLISTA_PROFESIONALES.DataSource = FILTRO_ESPECIALIDAD_PROFESIONAL;

                }
            }
        }
        private void MODO_GRILLA()
        {
            gbLISTA_PROFESIONALES.Enabled = true;
            gbDATOS_PROFESIONAL.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_PROFESIONALES.Enabled = false;
            gbDATOS_PROFESIONAL.Enabled = true;

            if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            }
            else
            {
                btnGUARDAR.Enabled = true;
            }
        }
        private void ARMA_COMBOBOX_ESPECIALIDAD()
        {
            cmbESPECIALIDAD.DataSource = null;
            cmbESPECIALIDAD.Items.Add("SELECCIONE...");
            cmbESPECIALIDAD.SelectedItem = "SELECCIONE...";
        }

        private Boolean EMAIL_BIEN_ESCRITO(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            oPROFESIONAL = new MODELO.PROFESIONAL();
            ACCION = "A";

            cmbESPECIALIDAD.DataSource = null;

            cmbESPECIALIDAD.ValueMember = "ID_ESPECIALIDAD";
            cmbESPECIALIDAD.DisplayMember = "NOMBRE";
            cmbESPECIALIDAD.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del profesional para poder registrarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtAPELLIDO.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del profesional para poder registrarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int64 CONTACTO;
            if (!Int64.TryParse(txtCONTACTO.Text, out CONTACTO))
            {
                MessageBox.Show("Debe ingresar un contacto de forma correcta para poder registrar al profesional", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCONTACTO.TextLength <= 5)
            {
                MessageBox.Show("El contacto es demasiado corto", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtCONTACTO.TextLength > 14)
            {
                MessageBox.Show("El contacto es demasiado largo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("Debe ingresar el email del profesional para poder registrarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!EMAIL_BIEN_ESCRITO(txtEMAIL.Text))
            {
                MessageBox.Show("El mail es incorrecto", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbESPECIALIDAD.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad para poder registrar el profesional", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            //ASIGNO MIS CONTROLES CON MIS ATRIBUTOS DEL MODELO
            oPROFESIONAL.NOMBRE = txtNOMBRE.Text.ToUpper();
            oPROFESIONAL.APELLIDO = txtAPELLIDO.Text.ToUpper();
            oPROFESIONAL.CONTACTO = CONTACTO;
            oPROFESIONAL.EMAIL = txtEMAIL.Text;
            oPROFESIONAL.FECHA = DateTime.Now;
            oPROFESIONAL.ESTADO = "ACTIVO";
            oPROFESIONAL.ESPECIALIDAD = (MODELO.ESPECIALIDAD)cmbESPECIALIDAD.SelectedItem;

            if (ACCION == "A")
            {
                oPROFESIONAL.ESTADO = "ACTIVO";
                cPROFESIONALES.AGREGAR_PROFESIONAL(oPROFESIONAL);
            }
            else if (ACCION == "M")
            {
                cPROFESIONALES.MODIFICAR_PROFESIONAL(oPROFESIONAL);
            }
            else if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            }

            // LIMPIO LA TEXTBOX         
            txtNOMBRE.Clear();
            txtAPELLIDO.Clear();
            txtCONTACTO.Clear();
            txtEMAIL.Clear();

            MODO_GRILLA();
            ARMA_GRILLA("A");
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PROFESIONALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPROFESIONAL = (MODELO.PROFESIONAL)dgvLISTA_PROFESIONALES.CurrentRow.DataBoundItem;

            ACCION = "M";

            txtNOMBRE.Text = oPROFESIONAL.NOMBRE.ToUpper();
            txtAPELLIDO.Text = oPROFESIONAL.APELLIDO.ToUpper();
            txtCONTACTO.Text = oPROFESIONAL.CONTACTO.ToString();
            txtEMAIL.Text = oPROFESIONAL.EMAIL;

            cmbESPECIALIDAD.ValueMember = "ID_ESPECIALIDAD";
            cmbESPECIALIDAD.DisplayMember = "NOMBRE";
            cmbESPECIALIDAD.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();

            cmbESPECIALIDAD.Text = oPROFESIONAL.ESPECIALIDAD.ToString();

            MODO_DATOS();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbFILTRO_ESPECIALIDAD.Text))
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ARMA_GRILLA("B");
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PROFESIONALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPROFESIONAL = (MODELO.PROFESIONAL)dgvLISTA_PROFESIONALES.CurrentRow.DataBoundItem;

            ACCION = "C";

            MODO_DATOS();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PROFESIONALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPROFESIONAL = (MODELO.PROFESIONAL)dgvLISTA_PROFESIONALES.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Esta seguro de eliminar el profesional " + oPROFESIONAL.NOMBRE + " " + oPROFESIONAL.APELLIDO + " de la lista de profesionales?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (RESPUESTA == DialogResult.Yes)
            {
                /*DateTime DIA_ACTUAL = DateTime.Now;
                var LISTA_TURNOS = (from a in cTURNOS.OBTENER_TURNOS()
                                    where a.FECHA > DIA_ACTUAL
                                    select a).ToList();
                foreach (var item in LISTA_TURNOS)
                {
                    oTURNO = (MODELO.TURNO)item;
                    oTURNO.ESTADO = "CANCELADO";
                    cTURNOS.MODIFICAR_TURNO(oTURNO);
                }*/

                /*var LISTA_ATENCIONES = (from a in cATENCIONES.OBTENER_ATENCIONES()
                                        where a.PROFESIONAL.ID_PROFESIONAL == oATENCION.PROFESIONAL.ID_PROFESIONAL
                                        select a).ToList();

                foreach (var items in LISTA_ATENCIONES)
                {
                    oATENCION = (MODELO.ATENCION)items;
                    oATENCION.ESTADO = "INACTIVO";
                    cATENCIONES.MODIFICAR_ATENCION(oATENCION);
                }*/

                oPROFESIONAL.ESTADO = "INACTIVO";
                cPROFESIONALES.MODIFICAR_PROFESIONAL(oPROFESIONAL);
                ARMA_GRILLA("A");
            }
        }

        private void btnRECUPERAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_PROFESIONALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista para poder recuperarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oPROFESIONAL = (MODELO.PROFESIONAL)dgvLISTA_PROFESIONALES.CurrentRow.DataBoundItem;
            if (oPROFESIONAL.ESTADO != "INACTIVO")
            {
                MessageBox.Show("Debe seleccionar un profesional inactivo para poder recuperarlo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult RESPUESTA = MessageBox.Show("¿Esta seguro de recuperar el profesional " + oPROFESIONAL.NOMBRE + " " + oPROFESIONAL.APELLIDO + " de la lista de profesionales?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (RESPUESTA == DialogResult.Yes)
            {
                oPROFESIONAL.ESTADO = "ACTIVO";
                cPROFESIONALES.MODIFICAR_PROFESIONAL(oPROFESIONAL);
                ARMA_GRILLA("A");
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            txtAPELLIDO.Clear();
            txtCONTACTO.Clear();
            txtEMAIL.Clear();

            ARMA_COMBOBOX_ESPECIALIDAD();
            MODO_GRILLA();
        }
    }
}
