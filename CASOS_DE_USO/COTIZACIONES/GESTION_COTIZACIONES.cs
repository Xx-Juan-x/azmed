using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.COTIZACIONES
{
    public class GESTION_COTIZACIONES
    {
        public static MODELO.COTIZACION OBTENER_COTIZACION(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.COTIZACIONES.Include("PROVEEDOR").Include("PEDIDO").FirstOrDefault(_ => _.ID_COTIZACION == CODIGO);
        }

        public static List<MODELO.COTIZACION> OBTENER_COTIZACIONES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.COTIZACIONES.Include("PROVEEDOR").Include("PEDIDO").ToList();
        }
    }
}
