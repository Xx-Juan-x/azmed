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
        public string EMAIL { get; set; }
        public string CLAVE { get; set; }
        public DateTime FECHA { get; set; }
        public string ESTADO { get; set; }
        public GRUPO GRUPO { get; set; }

        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
