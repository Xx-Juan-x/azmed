using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.AUDITORIA
{
    public class OPERACIONES_AUDITORIA
    {
        public static void AGREGAR_AUDITORIA(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.AUDITORIA AUDITORIA)
        {
            AZMED_CLINICA.AUDITORIA.Add(AUDITORIA);
        }

        public static void MODIFICAR_AUDITORIA(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.AUDITORIA AUDITORIA)
        {
            AZMED_CLINICA.Entry(AUDITORIA).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_AUDITORIA(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.AUDITORIA AUDITORIA)
        {
            AZMED_CLINICA.AUDITORIA.Remove(AUDITORIA);
        }
    }
}
