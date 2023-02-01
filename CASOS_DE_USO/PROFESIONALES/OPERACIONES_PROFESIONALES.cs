using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.PROFESIONALES
{
    public class OPERACIONES_PROFESIONALES
    {
        public static void AGREGAR_PROFESIONAL(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PROFESIONAL PROFESIONAL)
        {
            AZMED_CLINICA.PROFESIONALES.Add(PROFESIONAL);
        }

        public static void MODIFICAR_PROFESIONAL(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PROFESIONAL PROFESIONAL)
        {
            AZMED_CLINICA.Entry(PROFESIONAL).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_PROFESIONAL(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PROFESIONAL PROFESIONAL)
        {
            AZMED_CLINICA.PROFESIONALES.Remove(PROFESIONAL);
        }
    }
}
