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
    public partial class frmESPECIALIDAD : Form
    {
        //PATRON SINGLETON
        private static frmESPECIALIDAD instancia;

        public static frmESPECIALIDAD OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmESPECIALIDAD();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmESPECIALIDAD();
            }
            return instancia;
        }

        private CONTROLADORA.ESPECIALIDADES cESPECIALIDADES;
        private MODELO.ESPECIALIDAD oESPECIALIDAD;
        private CONTROLADORA.USUARIOS cUSUARIOS;
        string ACCION;
        private string ESP;
        public frmESPECIALIDAD()
        {
            InitializeComponent();
            cESPECIALIDADES = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            ARMA_GRILLA();
            MODO_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvLISTA_ESPECIALIDADES.DataSource = null;
            dgvLISTA_ESPECIALIDADES.DataSource = cESPECIALIDADES.OBTENER_ESPECIALIDADES();
        }

        private void MODO_GRILLA()
        {
            gbLISTA_ESPECIALIDADES.Enabled = true;
            gbDATOS_ESPECIALIDAD.Enabled = false;
        }

        private void MODO_DATOS()
        {
            gbLISTA_ESPECIALIDADES.Enabled = false;
            gbDATOS_ESPECIALIDAD.Enabled = true;

            if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            }
            else
            {
                btnGUARDAR.Enabled = true;
            }
        }

        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            oESPECIALIDAD = new MODELO.ESPECIALIDAD();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click_1(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la especialidad para poder agregarla", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double IMPORTE_CONSULTA;
            if (!double.TryParse(txtIMPORTE_CONSULTA.Text, out IMPORTE_CONSULTA))
            {
                MessageBox.Show("Debe ingresar un importe de consulta que tendrá la especialidad para poder agregarla al sistema", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double IMPORTE_ESTUDIO;
            if (!double.TryParse(txtIMPORTE_ESTUDIO.Text, out IMPORTE_ESTUDIO))
            {
                MessageBox.Show("Debe ingresar un importe de estudio que tendrá la especialidad para poder agregarla al sistema", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            // ASIGNO MI TEXTBOX CON MI PROPIEDAD
            oESPECIALIDAD.NOMBRE = txtNOMBRE.Text.ToUpper(); // Uso la funcion ToUapper para escribir el nombre en mayúscula
            oESPECIALIDAD.IMPORTE_CONSULTA = IMPORTE_CONSULTA;
            oESPECIALIDAD.IMPORTE_ESTUDIO = IMPORTE_ESTUDIO;

            if (ACCION == "A")
            {
                cESPECIALIDADES.AGREGAR_ESPECIALIDAD(oESPECIALIDAD);
            }
            else
            {
                cESPECIALIDADES.MODIFICAR_ESPECIALIDAD(oESPECIALIDAD);
            }

            // LIMPIO LA TEXTBOX
            txtNOMBRE.Clear();
            txtIMPORTE_CONSULTA.Clear();
            txtIMPORTE_ESTUDIO.Clear();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void btnMODIFICAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_ESPECIALIDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oESPECIALIDAD = (MODELO.ESPECIALIDAD)dgvLISTA_ESPECIALIDADES.CurrentRow.DataBoundItem;

            ACCION = "M";

            txtNOMBRE.Text = oESPECIALIDAD.NOMBRE.ToUpper();
            txtIMPORTE_CONSULTA.Text = oESPECIALIDAD.IMPORTE_CONSULTA.ToString();
            txtIMPORTE_ESTUDIO.Text = oESPECIALIDAD.IMPORTE_ESTUDIO.ToString();

            MODO_DATOS();
        }

        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_ESPECIALIDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oESPECIALIDAD = (MODELO.ESPECIALIDAD)dgvLISTA_ESPECIALIDADES.CurrentRow.DataBoundItem;

            ESP = "";
            foreach (DataGridViewRow row in dgvLISTA_ESPECIALIDADES.SelectedRows)
            {
                ESP = (string)row.Cells["NOMBRE"].Value;
            }
            
            if (ESP == "")
            {
                MessageBox.Show("Debe seleccionar la fila entera", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var LISTA_PROFESIONALES = (from a in cUSUARIOS.OBTENER_PROFESIONALES()
                                           where a.ESPECIALIDADES.NOMBRE == ESP
                                           select a).ToList();
                if (LISTA_PROFESIONALES.Count == 0)
                {

                    DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar la especialidad " + oESPECIALIDAD.NOMBRE + " de la lista de especialidades?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (RESPUESTA == DialogResult.Yes)
                    {
                        cESPECIALIDADES.ELIMINAR_ESPECIALIDAD(oESPECIALIDAD);
                        ARMA_GRILLA();
                    }
                }
                else
                {
                    MessageBox.Show("La especialidad ya cuenta con uno o mas profesionales, desvincule sus especialidades antes de borrar esta especialidad.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            txtIMPORTE_CONSULTA.Clear();
            txtIMPORTE_ESTUDIO.Clear();
            MODO_GRILLA();
        }

        private void btnCERRAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCONSULTAR_Click_1(object sender, EventArgs e)
        {
            if (dgvLISTA_ESPECIALIDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oESPECIALIDAD = (MODELO.ESPECIALIDAD)dgvLISTA_ESPECIALIDADES.CurrentRow.DataBoundItem;

            ACCION = "C";

            txtNOMBRE.Text = oESPECIALIDAD.NOMBRE.ToUpper();
            

            MODO_DATOS();

        }

        private void txtNOMBRE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIMPORTE_CONSULTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtIMPORTE_ESTUDIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

