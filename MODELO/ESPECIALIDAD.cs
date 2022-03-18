using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ESPECIALIDAD
    {
        #region PROPIEDADES
        public int ID_ESPECIALIDAD { get; set; }
        public string NOMBRE { get; set; }
        public double IMPORTE_CONSULTA { get; set; }
        public double IMPORTE_ESTUDIO { get; set; }
        #endregion

        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
