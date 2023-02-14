using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.TURNOS
{
    public class GESTION_TURNOS
    {
        public static MODELO.TURNO OBTENER_TURNO(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.TURNOS.Include("PACIENTE").Include("ESPECIALIDAD").Include("PROFESIONAL").FirstOrDefault(_ => _.ID_TURNO == CODIGO);
        }

        public static List<MODELO.TURNO> OBTENER_TURNOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.TURNOS.Include("PACIENTE").Include("ESPECIALIDAD").Include("PROFESIONAL").ToList();
        }
    }
}
