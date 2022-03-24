using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class COTIZACION
    {
        public int ID_COTIZACION { get; set; }
        public DateTime FECHA { get; set; }
        public string NOMBRE { get; set; }
        public string MOTIVO { get; set; }
        public PROVEEDOR PROVEEDOR { get; set; }
        public double PRECIO { get; set; }
        public SOLICITUD_PEDIDO PEDIDO { get; set; }
    }
}
