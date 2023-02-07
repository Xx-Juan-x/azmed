using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class PACIENTE
    {
        public int ID_PACIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public Int64 CONTACTO { get; set; }
        public string EMAIL { get; set; }
        public OBRA_SOCIAL OBRA_SOCIAL { get; set; }
        public PLAN PLAN { get; set; }
        public DateTime FECHA { get; set; }
        public string ESTADO { get; set; }

        public override string ToString()
        {
            return NOMBRE + " " + APELLIDO;
        }
    }
}
