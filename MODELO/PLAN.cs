using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class PLAN
    {
        public int ID_PLAN { get; set; }
        public string NOMBRE { get; set; }
        public OBRA_SOCIAL OBRA_SOCIAL { get; set; }
        public double DESCUENTO_CONSULTA { get; set; }
        public double DESCUENTO_ESTUDIO { get; set; }

        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
