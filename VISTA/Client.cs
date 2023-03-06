using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    //PATRON COMPOSITE: client
    public class Cliente : Composite
    {
        public Cliente(TreeView treeview = null)
        {
            arbol = treeview;
        }
        public TreeView arbol = new TreeView();
        public TreeView ObtenerVista()
        {
            return arbol;
        }
        public override void Agregar(Composite comp)
        {
            throw new NotImplementedException();
        }
        public void VistaArbol(List<Composite> mComponente, TreeNode pObjectTreeNode)
        {
            foreach (Composite c in mComponente)
            {
                if (pObjectTreeNode == null)
                {
                    arbol.Nodes.Add(new TreeNode(c.Nombre));
                    if (c._children != null && c._children.Count > 0)
                    {
                        VistaArbol(c._children, arbol.Nodes[arbol.GetNodeCount(false) - 1]);
                    }
                }
                else
                {
                    pObjectTreeNode.Nodes.Add(c.ID.ToString(), c.Nombre);
                    if (c._children != null && c._children.Count > 0)
                    {
                        VistaArbol(c._children, pObjectTreeNode.Nodes[pObjectTreeNode.GetNodeCount(false) - 1]);
                    }
                }

            }
        }       
    }
}
