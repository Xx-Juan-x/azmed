using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ORDEN_COMPRA
    {
       public int ID_ORDEN_COMPRA { get; set; }
       public SOLICITUD_PEDIDO PEDIDO { get; set; }
       public DateTime FECHA { get; set; }
       public string ESTADO { get; set; } 
    }
}
