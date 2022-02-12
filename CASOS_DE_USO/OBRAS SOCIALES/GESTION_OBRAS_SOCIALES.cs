using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.OBRAS_SOCIALES
{
    public class GESTION_OBRAS_SOCIALES
    {
        public static MODELO.OBRA_SOCIAL OBTENER_OBRA_SOCIAL(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.OBRAS_SOCIALES.FirstOrDefault(_ => _.ID_OBRA_SOCIAL == CODIGO);
        }

        public static List<MODELO.OBRA_SOCIAL> OBTENER_OBRAS_SOCIALES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.OBRAS_SOCIALES.ToList();
        }
    }
}
