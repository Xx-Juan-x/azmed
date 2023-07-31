using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class LISTA_COMPRA
    {
        public int ID_LISTA_COMPRA { get; set; }
        public ORDEN_COMPRA COMPRA { get; set; }
        public LISTA_COTIZACION LISTA_COTIZACION { get; set; }
        public int CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
    }
}
