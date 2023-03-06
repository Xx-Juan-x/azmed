using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISTA
{
    //PATRON COMPOSITE: composite
    abstract public class Composite
    {
        public virtual int ID { get; set; }
        public virtual string Nombre { get; set; }
        public List<Composite> _children = new List<Composite>();
        abstract public void Agregar(Composite comp);
    }
}
