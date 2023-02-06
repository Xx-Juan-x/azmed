using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class PROFESIONAL
    {
        public int ID_PROFESIONAL { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public Int64 CONTACTO { get; set; }
        public string EMAIL { get; set; }
        public ESPECIALIDAD ESPECIALIDAD { get; set; }
        public DateTime FECHA { get; set; }
        public string ESTADO { get; set; }
    }
}
