using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.PACIENTES
{
    public class GESTION_PACIENTES
    {
        public static MODELO.PACIENTE OBTENER_PACIENTE(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.PACIENTES.FirstOrDefault(_ => _.ID_PACIENTE == CODIGO);
        }

        public static List<MODELO.PACIENTE> OBTENER_PACIENTES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.PACIENTES.ToList();
        }
    }
}
