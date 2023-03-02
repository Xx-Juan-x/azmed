using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.TURNOS
{
    public class OPERACIONES_TURNOS
    {
        public static void AGREGAR_TURNO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.TURNO TURNO)
        {
            AZMED_CLINICA.TURNOS.Add(TURNO);
        }

        public static void MODIFICAR_TURNO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.TURNO TURNO)
        {
            AZMED_CLINICA.Entry(TURNO).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_TURNO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.TURNO TURNO)
        {
            AZMED_CLINICA.TURNOS.Remove(TURNO);
        }


    }
}
