using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.ESPECIALIDADES
{
    public class OPERACIONES_ESPECIALIDADES
    {
        public static void AGREGAR_ESPECIALIDAD(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ESPECIALIDAD ESPECIALIDAD)
        {
            AZMED_CLINICA.ESPECIALIDADES.Add(ESPECIALIDAD);
        }

        public static void MODIFICAR_ESPECIALIDAD(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ESPECIALIDAD ESPECIALIDAD)
        {
            AZMED_CLINICA.Entry(ESPECIALIDAD).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_ESPECIALIDAD(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ESPECIALIDAD ESPECIALIDAD)
        {
            AZMED_CLINICA.ESPECIALIDADES.Remove(ESPECIALIDAD);
        }

    }
}
