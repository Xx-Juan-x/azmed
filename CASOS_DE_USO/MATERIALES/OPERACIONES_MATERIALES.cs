using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.MATERIALES
{
    public class OPERACIONES_MATERIALES
    {
        public static void AGREGAR_MATERIAL(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.MATERIAL MATERIAL)
        {
            AZMED_CLINICA.MATERIALES.Add(MATERIAL);
        }

        public static void MODIFICAR_MATERIAL(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.MATERIAL MATERIAL)
        {
            AZMED_CLINICA.Entry(MATERIAL).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_MATERIAL(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.MATERIAL MATERIAL)
        {
            AZMED_CLINICA.MATERIALES.Remove(MATERIAL);
        }
    }
}
