using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.PACIENTES
{
    public class OPERACIONES_PACIENTES
    {
        public static void AGREGAR_PACIENTE(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PACIENTE PACIENTE)
        {
            AZMED_CLINICA.PACIENTES.Add(PACIENTE);
        }

        public static void MODIFICAR_PACIENTE(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PACIENTE PACIENTE)
        {
            AZMED_CLINICA.Entry(PACIENTE).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_PACIENTE(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PACIENTE PACIENTE)
        {
            AZMED_CLINICA.PACIENTES.Remove(PACIENTE);
        }
    }
}
