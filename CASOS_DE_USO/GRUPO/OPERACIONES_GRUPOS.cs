using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.GRUPO
{
    public class OPERACIONES_GRUPOS
    {
        public static void AGREGAR_GRUPO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.GRUPO GRUPO)
        {
            AZMED_CLINICA.GRUPO.Add(GRUPO);
        }

        public static void MODIFICAR_GRUPO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.GRUPO GRUPO)
        {
            AZMED_CLINICA.Entry(GRUPO).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_GRUPO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.GRUPO GRUPO)
        {
            AZMED_CLINICA.GRUPO.Remove(GRUPO);
        }
    }
}
