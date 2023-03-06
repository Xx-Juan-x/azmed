using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.ACCIONES_GRUPOS
{
    public class OPERACIONES_ACCIONES_GRUPOS
    {
        public static void AGREGAR_ACCIONES_GRUPOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ACCIONES_GRUPOS ACCIONES_GRUPOS)
        {
            AZMED_CLINICA.ACCIONES_GRUPOS.Add(ACCIONES_GRUPOS);
        }

        public static void MODIFICAR_ACCIONES_GRUPOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ACCIONES_GRUPOS ACCIONES_GRUPOS)
        {
            AZMED_CLINICA.Entry(ACCIONES_GRUPOS).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_ACCIONES_GRUPOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ACCIONES_GRUPOS ACCIONES_GRUPOS)
        {
            AZMED_CLINICA.ACCIONES_GRUPOS.Remove(ACCIONES_GRUPOS);
        }

    }
}
