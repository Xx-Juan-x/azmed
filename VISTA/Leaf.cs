using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISTA
{
    //PATRON COMPOSITE: Leaf
    public class Leaf : Composite
    {
        public override string Nombre { get; set; }
        public override int ID { get; set; }
        public Leaf(string nombre, int id)//Constructor
        {
            Nombre = nombre;
            ID = id;
        }
        public override void Agregar(Composite comp)
        {
            throw new NotImplementedException();
        }

    }
}
