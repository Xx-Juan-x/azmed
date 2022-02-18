using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.ATENCION
{
    public class OPERACIONES_ATENCIONES
    {
        public static void AGREGAR_ATENCION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ATENCION ATENCION)
        {
            AZMED_CLINICA.ATENCIONES.Add(ATENCION);
        }

        public static void MODIFICAR_ATENCION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ATENCION ATENCION)
        {
            AZMED_CLINICA.Entry(ATENCION).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_ATENCION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ATENCION ATENCION)
        {
            AZMED_CLINICA.ATENCIONES.Remove(ATENCION);
        }
    }
}
