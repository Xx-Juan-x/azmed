using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.MATERIALES
{
    public class GESTION_MATERIALES
    {
        public static MODELO.MATERIAL OBTENER_MATERIAL(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.MATERIALES.FirstOrDefault(_ => _.ID_MATERIAL == CODIGO);
        }

        public static List<MODELO.MATERIAL> OBTENER_MATERIALES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.MATERIALES.ToList();
        }
    }
}
