using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class SOLICITUD_PEDIDO
    {
        public int ID_SOLICITUD_PEDIDO { get; set; }
        public string DESCRIPCION { get; set; }
        public DateTime FECHA { get; set; }
        public string ESTADO { get; set; }       
    }
}
