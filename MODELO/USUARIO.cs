using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class USUARIO
    {
        public int ID_USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string EMAIL { get; set; }
        public string CLAVE { get; set; }
        public DateTime FECHA { get; set; }
        public string TIPO { get; set; }
        public ESPECIALIDAD ESPECIALIDADES { get; set; }
        public PLAN PLAN { get; set; }
        public OBRA_SOCIAL OBRA_SOCIAL { get; set; }

        public override string ToString()
        {
            return NOMBRE + " " + APELLIDO;
        }
    }
}
