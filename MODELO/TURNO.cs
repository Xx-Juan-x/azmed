using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class TURNO
    {
        public int ID_TURNO { get; set; }
        public int HORA_TURNO { get; set; }
        public DayOfWeek DIA { get; set; }
        public USUARIO PACIENTE { get; set; }
        public PLAN PLAN { get; set; }
        public OBRA_SOCIAL OBRA_SOCIAL { get; set; }          
        public ESPECIALIDAD ESPECIALIDAD { get; set; }
        public USUARIO PROFESIONAL { get; set; }
        public DateTime FECHA { get; set; }
        public string TIPO { get; set; }
    }
}
