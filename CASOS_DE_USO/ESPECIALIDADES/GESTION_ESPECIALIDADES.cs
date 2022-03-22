using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.ESPECIALIDADES
{
    public class GESTION_ESPECIALIDADES
    {
        public static MODELO.ESPECIALIDAD OBTENER_ESPECIALIDAD(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.ESPECIALIDADES.FirstOrDefault(_ => _.ID_ESPECIALIDAD == CODIGO);
        }

        public static List<MODELO.ESPECIALIDAD> OBTENER_ESPECIALIDADES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.ESPECIALIDADES.ToList();
        }
    }
}
