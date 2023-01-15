using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.GRUPO
{
    public class GESTION_GRUPOS
    {
        public static MODELO.GRUPO OBTENER_GRUPO(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.GRUPO.FirstOrDefault(_ => _.ID_GRUPO == CODIGO);
        }

        public static List<MODELO.GRUPO> OBTENER_GRUPOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.GRUPO.ToList();
        }
    }
}
