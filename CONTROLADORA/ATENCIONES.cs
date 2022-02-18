using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ATENCIONES
    {
        // PATRON SINGLETON
        private static ATENCIONES instancia;

        public static ATENCIONES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new ATENCIONES();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private ATENCIONES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_ATENCION(MODELO.ATENCION ATENCION)
        {
            CASOS_DE_USO.ATENCION.OPERACIONES_ATENCIONES.AGREGAR_ATENCION(oCONTEXTO, ATENCION);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_ATENCION(MODELO.ATENCION ATENCION)
        {
            CASOS_DE_USO.ATENCION.OPERACIONES_ATENCIONES.MODIFICAR_ATENCION(oCONTEXTO, ATENCION);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_ATENCION(MODELO.ATENCION ATENCION)
        {
            CASOS_DE_USO.ATENCION.OPERACIONES_ATENCIONES.ELIMINAR_ATENCION(oCONTEXTO, ATENCION);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.ATENCION OBTENER_ATENCION(int CODIGO)
        {
            return CASOS_DE_USO.ATENCION.GESTION_ATENCIONES.OBTENER_ATENCION(CODIGO, oCONTEXTO);
        }

        public List<MODELO.ATENCION> OBTENER_ATENCIONES()
        {
            return CASOS_DE_USO.ATENCION.GESTION_ATENCIONES.OBTENER_ATENCIONES(oCONTEXTO);
        }
    }
}
