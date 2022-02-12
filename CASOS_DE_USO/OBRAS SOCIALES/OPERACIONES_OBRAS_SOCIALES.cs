using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.OBRAS_SOCIALES
{
    public class OPERACIONES_OBRAS_SOCIALES
    {
        public static void AGREGAR_OBRA_SOCIAL(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.OBRA_SOCIAL OBRA_SOCIAL)
        {
            AZMED_CLINICA.OBRAS_SOCIALES.Add(OBRA_SOCIAL);
        }

        public static void MODIFICAR_OBRA_SOCIAL(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.OBRA_SOCIAL OBRA_SOCIAL)
        {
            AZMED_CLINICA.Entry(OBRA_SOCIAL).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_OBRA_SOCIAL(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.OBRA_SOCIAL OBRA_SOCIAL)
        {
            AZMED_CLINICA.OBRAS_SOCIALES.Remove(OBRA_SOCIAL);
        }
    }
}
