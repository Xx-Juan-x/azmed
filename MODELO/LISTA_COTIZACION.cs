using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class LISTA_COTIZACION
    {
        public int ID_LISTA_COTIZACION { get; set; }
        public MATERIAL MATERIAL { get; set; }
        public COTIZACION COTIZACION { get; set; }
        public decimal PRECIO { get; set; }
    }
}
