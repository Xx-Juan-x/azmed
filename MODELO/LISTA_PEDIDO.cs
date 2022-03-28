using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class LISTA_PEDIDO
    {
        public int ID_LISTA_PEDIDO { get; set; }
        public MATERIAL INSUMO { get; set; }
        public SOLICITUD_PEDIDO PEDIDO { get; set; }       
    }
}
