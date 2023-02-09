using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class GRUPO
    {
        public int ID_GRUPO { get; set; }   
        public string NOMBRE { get; set; }
        public string ESTADO { get; set; }

        public override string ToString()
        {
            return NOMBRE;
        }

    }
}
