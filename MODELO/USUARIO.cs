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
        public int ID_ROL { get; set; }
        public ROL ROL { get; set; }
    }
}
