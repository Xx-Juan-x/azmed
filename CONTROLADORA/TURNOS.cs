using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class TURNOS
    {
        private static TURNOS instancia;

        public static TURNOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new TURNOS();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private TURNOS()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_TURNO(MODELO.TURNO TURNO)
        {
            CASOS_DE_USO.TURNOS.OPERACIONES_TURNOS.AGREGAR_TURNO(oCONTEXTO, TURNO);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_TURNO(MODELO.TURNO TURNO)
        {
            CASOS_DE_USO.TURNOS.OPERACIONES_TURNOS.MODIFICAR_TURNO(oCONTEXTO, TURNO);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_TURNO(MODELO.TURNO TURNO)
        {
            CASOS_DE_USO.TURNOS.OPERACIONES_TURNOS.ELIMINAR_TURNO(oCONTEXTO, TURNO);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.TURNO OBTENER_TURNO(int CODIGO)
        {
            return CASOS_DE_USO.TURNOS.GESTION_TURNOS.OBTENER_TURNO(CODIGO, oCONTEXTO);
        }

        public List<MODELO.TURNO> OBTENER_TURNOS()
        {
            return CASOS_DE_USO.TURNOS.GESTION_TURNOS.OBTENER_TURNOS(oCONTEXTO);
        }
    }
}
