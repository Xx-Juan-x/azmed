using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MATERIAL
    {
        public int ID_MATERIAL { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public int STOCK { get; set; }

        public override string ToString()
        {
            return NOMBRE;
        }

    }
}
