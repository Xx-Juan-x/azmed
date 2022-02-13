using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.PLANES
{
    public class OPERACIONES_PLANES
    {
        public static void AGREGAR_PLAN(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PLAN PLAN)
        {
            AZMED_CLINICA.PLANES.Add(PLAN);
        }

        public static void MODIFICAR_PLAN(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PLAN PLAN)
        {
            AZMED_CLINICA.Entry(PLAN).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_PLAN(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PLAN PLAN)
        {
            AZMED_CLINICA.PLANES.Remove(PLAN);
        }

    }
}
