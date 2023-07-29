using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class AUDITORIA_USUARIO
    {
        public int ID_AUDITORIA { get; set; }
        public string USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string EMAIL { get; set; }
        public DateTime FECHA_HORA { get; set; }
        public string ACCION { get; set; }
        public string DATOS_REGISTRADOS { get; set; }

    }
}
