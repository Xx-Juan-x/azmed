using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.PLANES
{
   public class GESTION_PLANES
    {
        public static MODELO.PLAN OBTENER_PLAN(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.PLANES.Include("OBRA_SOCIAL").FirstOrDefault(_ => _.ID_PLAN == CODIGO);
        }

        public static List<MODELO.PLAN> OBTENER_PLANES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.PLANES.Include("OBRA_SOCIAL").ToList();
        }

    }
}
