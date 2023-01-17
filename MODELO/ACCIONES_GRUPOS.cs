using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ACCIONES_GRUPOS
    {
        public int ID_ACCION_GRUPO { get; set; }

        public GRUPO GRUPO { get; set; }

        public ACCIONES ACCION { get; set; }
    }
}
