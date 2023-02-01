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
        public string DIA_LABORAL { get; set; }

        //COLOCAR EL ID DE LA TABLA PROFESIONAL
        public PROFESIONAL PROFESIONAL { get; set; }
        public ESPECIALIDAD ESPECIALIDAD { get; set; }
        public int HORA_INICIO { get; set; }
        public int HORA_FIN { get; set; }
        public string ESTADO { get; set; }
        
    }
}
