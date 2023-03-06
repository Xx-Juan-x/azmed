using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISTA
{
    public class Branch : Composite
    {
        private CONTROLADORA.GRUPOS cGRUPOS;
        private CONTROLADORA.ACCIONES cACCIONES;
        private CONTROLADORA.ACCIONES_GRUPOS cACCIONES_GRUPOS;
        private MODELO.ACCIONES_GRUPOS oACCIONES_GRUPOS;
        private MODELO.ACCIONES oACCIONES;
        private MODELO.GRUPO oGRUPO;
        public override string Nombre { get; set; }
        public override int ID { get; set; }
        public Branch(string nombre, int id)//Constructor
        {
            cGRUPOS = CONTROLADORA.GRUPOS.OBTENER_INSTANCIA();
            cACCIONES = CONTROLADORA.ACCIONES.OBTENER_INSTANCIA();
            cACCIONES_GRUPOS = CONTROLADORA.ACCIONES_GRUPOS.OBTENER_INSTANCIA();
            Nombre = nombre;
            ID = id;
            buscarAcciones();
        }
        public override void Agregar(Composite comp)
        {
            this._children.Add(comp);
        }
        public virtual void buscarAcciones()
        {
            var grupos = (from a in cACCIONES_GRUPOS.OBTENER_ACCIONES_GRUPOS() where a.GRUPO_ID_GRUPO == this.ID select a).ToList();
            foreach (var g in grupos)
            {
                Leaf hoja = new Leaf(g.ACCION.DESCRIPCION, g.ACCION.ID_ACCIONES);
                this.Agregar(hoja);
            }
        }

    }
}
