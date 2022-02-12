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
        string ACCION;

        public frmESPECIALIDAD()
        {
            InitializeComponent();
            cESPECIALIDADES = CONTROLADORA.ESPECIALIDADES.OBTENER_INSTANCIA();
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

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            oESPECIALIDAD = new MODELO.ESPECIALIDAD();
            ACCION = "A";
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la especialidad para poder agregarla", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal PRECIO;
            if (!decimal.TryParse(txtPRECIO.Text, out PRECIO))
            {
                MessageBox.Show("Debe ingresarle un precio a la especialidad", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion

            // ASIGNO MI TEXTBOX CON MI PROPIEDAD
            oESPECIALIDAD.NOMBRE = txtNOMBRE.Text.ToUpper(); // Uso la funcion ToUapper para escribir el nombre en mayúscula
            oESPECIALIDAD.PRECIO = PRECIO;

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
            txtPRECIO.Clear();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_ESPECIALIDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad de la lista para poder modificar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oESPECIALIDAD = (MODELO.ESPECIALIDAD)dgvLISTA_ESPECIALIDADES.CurrentRow.DataBoundItem;

            ACCION = "M";

            txtNOMBRE.Text = oESPECIALIDAD.NOMBRE;
            txtPRECIO.Text = oESPECIALIDAD.PRECIO.ToString();

            MODO_DATOS();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_ESPECIALIDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad de la lista para poder eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oESPECIALIDAD = (MODELO.ESPECIALIDAD)dgvLISTA_ESPECIALIDADES.CurrentRow.DataBoundItem;

            DialogResult RESPUESTA = MessageBox.Show("¿Desea eliminar la especialidad " + oESPECIALIDAD.NOMBRE + " de la lista de especialidades?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RESPUESTA == DialogResult.Yes)
            {
                cESPECIALIDADES.ELIMINAR_ESPECIALIDAD(oESPECIALIDAD);
                ARMA_GRILLA();
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            txtNOMBRE.Clear();
            txtPRECIO.Clear();
            MODO_GRILLA();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_ESPECIALIDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad de la lista para poder consultar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oESPECIALIDAD = (MODELO.ESPECIALIDAD)dgvLISTA_ESPECIALIDADES.CurrentRow.DataBoundItem;

            ACCION = "C";

            txtNOMBRE.Text = oESPECIALIDAD.NOMBRE;
            txtPRECIO.Text = oESPECIALIDAD.PRECIO.ToString();

            MODO_DATOS();

        }
    }
}

