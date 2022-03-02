using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class FACTURACIONES
    {
        private static FACTURACIONES instancia;

        public static FACTURACIONES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new FACTURACIONES();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private FACTURACIONES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_FACTURACION(MODELO.FACTURACION FACTURACION)
        {
            CASOS_DE_USO.FACTURACION.OPERACIONES_FACTURACION.AGREGAR_FACTURACION(oCONTEXTO, FACTURACION);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_FACTURACION(MODELO.FACTURACION FACTURACION)
        {
            CASOS_DE_USO.FACTURACION.OPERACIONES_FACTURACION.MODIFICAR_FACTURACION(oCONTEXTO, FACTURACION);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_FACTURACION(MODELO.FACTURACION FACTURACION)
        {
            CASOS_DE_USO.FACTURACION.OPERACIONES_FACTURACION.ELIMINAR_FACTURACION(oCONTEXTO, FACTURACION);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.FACTURACION OBTENER_FACTURACION(int CODIGO)
        {
            return CASOS_DE_USO.FACTURACION.GESTION_FACTURACION.OBTENER_FACTURACION(CODIGO, oCONTEXTO);
        }

        public List<MODELO.FACTURACION> OBTENER_FACTURACIONES()
        {
            return CASOS_DE_USO.FACTURACION.GESTION_FACTURACION.OBTENER_FACTURACIONES(oCONTEXTO);
        }
    }
}
