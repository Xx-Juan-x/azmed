using CONTROLADORA;
using MODELO;
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
    public partial class frmACCIONES : Form
    {
        private CONTROLADORA.GRUPOS cGRUPOS;
        private CONTROLADORA.ACCIONES cACCIONES;
        private CONTROLADORA.ACCIONES_GRUPOS cACCIONES_GRUPOS;
        private MODELO.ACCIONES_GRUPOS oACCIONES_GRUPOS;
        private MODELO.ACCIONES oACCIONES;
        private MODELO.GRUPO oGRUPO;
        private static frmACCIONES instancia;
        int grupo_desasignar;

        public static frmACCIONES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmACCIONES();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmACCIONES();
            }
            return instancia;
        }
        public frmACCIONES()
        {
            cGRUPOS = CONTROLADORA.GRUPOS.OBTENER_INSTANCIA();
            cACCIONES = CONTROLADORA.ACCIONES.OBTENER_INSTANCIA();
            cACCIONES_GRUPOS = CONTROLADORA.ACCIONES_GRUPOS.OBTENER_INSTANCIA();

            InitializeComponent();
            List<COMBOBOX_GRUPOS> LISTA_GRUPOS = new List<COMBOBOX_GRUPOS>();
            LISTA_GRUPOS.Add(new COMBOBOX_GRUPOS("SELECCIONE...", -1));
            var grupos = (from  a in cGRUPOS.OBTENER_GRUPOS() select a).ToList();
            foreach (var g in grupos)
            {
                LISTA_GRUPOS.Add(new COMBOBOX_GRUPOS(g.NOMBRE.ToString(),g.ID_GRUPO));
            }
            cmbGRUPOS.DataSource = LISTA_GRUPOS;

            List<COMBOBOX_ACCIONES> LISTA_ACCIONES = new List<COMBOBOX_ACCIONES>();
            LISTA_ACCIONES.Add(new COMBOBOX_ACCIONES("SELECCIONE...", -1));
            var acciones = cACCIONES.OBTENER_ACCIONES().ToList();
            foreach (var a in acciones)
            {
                LISTA_ACCIONES.Add(new COMBOBOX_ACCIONES(a.DESCRIPCION.ToString(), a.ID_ACCIONES));
            }
            cmb_ACCIONES.DataSource = LISTA_ACCIONES;
            ARMAR_VISTA();
        }
        private void ARMAR_VISTA()
        {
            var grupos = (from a in cGRUPOS.OBTENER_GRUPOS() select a).ToList();
            Branch raiz = new Branch("RAIZ", 0);
            foreach (var g in grupos)
            {
                Branch rama = new Branch(g.NOMBRE.ToString(), g.ID_GRUPO);
                raiz.Agregar(rama);
            }

            Cliente client = new Cliente(treeViewGrupo);
            client.VistaArbol(raiz._children, null);
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnASIGNAR_ACCION_Click(object sender, EventArgs e)
        {
            COMBOBOX_GRUPOS cmb_g = (COMBOBOX_GRUPOS)cmbGRUPOS.SelectedValue;
            if (cmb_ACCIONES.SelectedIndex != -1 && cmb_g.CMB_VALOR != -1)
            {
                string gr = cmbGRUPOS.SelectedItem.ToString();
                string ac = cmb_ACCIONES.SelectedItem.ToString();
                oACCIONES = (from a in cACCIONES.OBTENER_ACCIONES() where a.DESCRIPCION == ac select a).FirstOrDefault();
                var yaExiste = (from b in cACCIONES_GRUPOS.OBTENER_ACCIONES_GRUPOS() where b.GRUPO_ID_GRUPO == cmb_g.CMB_VALOR && b.ACCION.DESCRIPCION == ac select b).FirstOrDefault();

                if (yaExiste != null)
                {
                    MessageBox.Show("La acción " + oACCIONES.DESCRIPCION + " ya se encuentra asignada a este grupo, pruebe con otra acción", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    oACCIONES_GRUPOS = new MODELO.ACCIONES_GRUPOS();
                    oACCIONES_GRUPOS.GRUPO_ID_GRUPO = cmb_g.CMB_VALOR;
                    oACCIONES_GRUPOS.ACCION = oACCIONES;
                    cACCIONES_GRUPOS.AGREGAR_ACCIONES_GRUPOS(oACCIONES_GRUPOS);
                    MessageBox.Show("Se ha guardado la asignacion de la accion " + ac, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    treeViewGrupo.Refresh();
                    treeViewGrupo.Nodes.Clear();
                    ARMAR_VISTA();
                }
                
            }
        }

        private void treeViewGrupo_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var accion = e.Node;
            if (accion.Text != "PROFESIONAL" && accion.Text != "JEFE DE COMPRAS" && accion.Text != "ADMINISTRADOR")
            {
                txt_ACCION.Text = accion.Text;
                if (e.Node.Parent.Text == "PROFESIONAL") grupo_desasignar = 3;
                if (e.Node.Parent.Text == "ADMINISTRADOR") grupo_desasignar = 2;
                if (e.Node.Parent.Text == "JEFE DE COMPRAS") grupo_desasignar = 4;
                btn_DESASIGNAR.Enabled = true;
            }
            

        }

        private void btn_DESASIGNAR_Click(object sender, EventArgs e)
        {
            var accion_grupo = (from a in cACCIONES_GRUPOS.OBTENER_ACCIONES_GRUPOS() where a.GRUPO_ID_GRUPO == grupo_desasignar && a.ACCION.DESCRIPCION == txt_ACCION.Text select a).ToList();
            cACCIONES_GRUPOS.ELIMINAR_ACCIONES_GRUPOS(accion_grupo[0]);
            MessageBox.Show("Se ha desasignado la accion al grupo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            treeViewGrupo.Refresh();
            treeViewGrupo.Nodes.Clear();
            ARMAR_VISTA();
        }
    }
    class COMBOBOX_ACCIONES
    {
        public string CMB_TEXTO { get; set; }
        public int CMB_VALOR { get; set; }//11
        public COMBOBOX_ACCIONES(string T, int V)
        {
            CMB_TEXTO = T;
            CMB_VALOR = V;
        }
        public override string ToString()
        {
            return CMB_TEXTO;
        }
    }
    class COMBOBOX_GRUPOS
    {
        public string CMB_TEXTO { get; set; }
        public int CMB_VALOR { get; set; }//11
        public COMBOBOX_GRUPOS(string T, int V)
        {
            CMB_TEXTO = T;
            CMB_VALOR = V;
        }
        public override string ToString()
        {
            return CMB_TEXTO;
        }
    }
}
