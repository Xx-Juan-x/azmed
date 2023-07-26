using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VISTA
{
    public partial class frmBACKUP_RESTAURACION : Form
    {
        private static frmBACKUP_RESTAURACION instancia;

        public static frmBACKUP_RESTAURACION OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmBACKUP_RESTAURACION();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmBACKUP_RESTAURACION();
            }
            return instancia;
        }

        SqlConnection CONEXION = new SqlConnection("Data Source=JUAN\\SQLEXPRESS;Initial Catalog=CONTEXTO.CLINICA_AZMED;Integrated Security=True");

        public frmBACKUP_RESTAURACION()
        {
            InitializeComponent();
        }

        private void btnNAVEGADOR1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLOCALIZACION1.Text = dlg.SelectedPath;
                btnBACKUP.Enabled = true;
            }
        }

        private void btnBACKUP_Click(object sender, EventArgs e)
        {
            string DATABASE = CONEXION.Database.ToString();
            if (txtLOCALIZACION1.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingrese la ubicación del archivo de copia de seguridad", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + DATABASE + "] TO DISK= '" + txtLOCALIZACION1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                CONEXION.Open();
                SqlCommand COMANDO = new SqlCommand(cmd, CONEXION);
                COMANDO.ExecuteNonQuery();
                MessageBox.Show("Copia de seguridad de la base de datos realizada con éxito", "COPIA DE SEGURIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CONEXION.Close();
                btnBACKUP.Enabled = false;
            }
        }

        private void btnNAVEGADOR2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files |* .bak";
            dlg.Title = "Restaurar Base de Datos";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLOCALIZACION2.Text = dlg.FileName;
                btnRESTAURAR.Enabled = true;
            }
        }

        private void btnRESTAURAR_Click(object sender, EventArgs e)
        {
            string DATABASE = CONEXION.Database.ToString();
            CONEXION.Open();

            try
            {
                string str1 = string.Format("ALTER DATABASE [" + DATABASE + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, CONEXION);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + DATABASE + "] FROM DISK='" + txtLOCALIZACION2.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, CONEXION);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + DATABASE + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, CONEXION);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Restauración de la base de datos realizada con éxito", "RESTAURACION BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CONEXION.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la restauración de la base de datos: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
