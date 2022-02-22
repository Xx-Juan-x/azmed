using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ATENCION
    {
        public int ID_ATENCION { get; set; }
        public string PROFESIONAL { get; set; }
        public DateTime HORA_INICIO { get; set; }
        public DateTime HORA_FIN { get; set; }
        public string DIA_LABORAL { get; set; }
    }
}
