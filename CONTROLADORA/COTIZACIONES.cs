using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class COTIZACIONES
    {
        // PATRON SINGLETON
        private static COTIZACIONES instancia;

        public static COTIZACIONES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new COTIZACIONES();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private COTIZACIONES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_COTIZACION(MODELO.COTIZACION COTIZACION)
        {
            CASOS_DE_USO.COTIZACIONES.OPERACIONES_COTIZACIONES.AGREGAR_COTIZACION(oCONTEXTO, COTIZACION);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_COTIZACION(MODELO.COTIZACION COTIZACION)
        {
            CASOS_DE_USO.COTIZACIONES.OPERACIONES_COTIZACIONES.MODIFICAR_COTIZACION(oCONTEXTO, COTIZACION);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_COTIZACION(MODELO.COTIZACION COTIZACION)
        {
            CASOS_DE_USO.COTIZACIONES.OPERACIONES_COTIZACIONES.ELIMINAR_COTIZACION(oCONTEXTO, COTIZACION);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.COTIZACION OBTENER_COTIZACION(int CODIGO)
        {
            return CASOS_DE_USO.COTIZACIONES.GESTION_COTIZACIONES.OBTENER_COTIZACION(CODIGO, oCONTEXTO);
        }

        public List<MODELO.COTIZACION> OBTENER_COTIZACIONES()
        {
            return CASOS_DE_USO.COTIZACIONES.GESTION_COTIZACIONES.OBTENER_COTIZACIONES(oCONTEXTO);
        }
    }
}
