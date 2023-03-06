using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ACCIONES
    {
        // PATRON SINGLETON
        private static ACCIONES instancia;

        public static ACCIONES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new ACCIONES();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private ACCIONES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public MODELO.ACCIONES OBTENER_ACCION(int CODIGO)
        {
            return CASOS_DE_USO.ACCIONES.GESTION_ACCIONES.OBTENER_ACCION(CODIGO, oCONTEXTO);
        }

        public List<MODELO.ACCIONES> OBTENER_ACCIONES()
        {
            return CASOS_DE_USO.ACCIONES.GESTION_ACCIONES.OBTENER_ACCIONES(oCONTEXTO);
        }
    }
}
