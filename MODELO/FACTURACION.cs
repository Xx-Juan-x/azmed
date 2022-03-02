using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class FACTURACION
    {
        public int NRO_LEGAJO { get; set; }
        public USUARIO PACIENTE { get; set; }
        public TURNO TIPO { get; set; }
        public TURNO OBRA_SOCIAL { get; set; }
        public TURNO PLAN { get; set; }
        public TURNO ESPECIALIDAD { get;  }
        public TURNO PROFESIONAL { get; set; }
        public DateTime FECHA { get; set; }
        public decimal MONTO { get; set; }
        public decimal DESCUENTO { get; set; }
        public decimal PRECIO_FINAL { get; set; }
    }
}
