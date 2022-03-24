using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class SOLICITUD_PEDIDO
    {
        public int ID_PEDIDO { get; set; }
        public DateTime FECHA { get; set; }
        public string ESTADO { get; set; }
        public int CANTIDAD { get; set; }
        public MATERIAL INSUMO { get; set; }

        public override string ToString()
        {
            return ID_PEDIDO + " " + FECHA.ToShortDateString() + " " + INSUMO;
        }

    }
}
