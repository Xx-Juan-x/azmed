using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.PROFESIONALES
{
    public class GESTION_PROFESIONALES
    {
        public static MODELO.PROFESIONAL OBTENER_PROFESIONAL(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.PROFESIONALES.FirstOrDefault(_ => _.ID_PROFESIONAL == CODIGO);
        }

        public static List<MODELO.PROFESIONAL> OBTENER_PROFESIONALES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.PROFESIONALES.ToList();
        }
    }
}
