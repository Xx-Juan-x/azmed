using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.LISTA_COTIZACION
{
    public class GESTION_LISTA_COTIZACIONES
    {
        public static MODELO.LISTA_COTIZACION OBTENER_LISTA_COTIZACION(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        { 
            return AZMED_CLINICA.LISTA_COTIZACION.Include("COTIZACION").Include("MATERIAL").FirstOrDefault(_ => _.ID_LISTA_COTIZACION == CODIGO);
        }

        public static List<MODELO.LISTA_COTIZACION> OBTENER_LISTA_COTIZACIONES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.LISTA_COTIZACION.Include("COTIZACION").Include("MATERIAL").ToList();

        }
    }
}
