using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.COTIZACIONES
{
    public class OPERACIONES_COTIZACIONES
    {
        public static void AGREGAR_COTIZACION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.COTIZACION COTIZACION)
        {
            AZMED_CLINICA.COTIZACIONES.Add(COTIZACION);
        }

        public static void MODIFICAR_COTIZACION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.COTIZACION COTIZACION)
        {
            AZMED_CLINICA.Entry(COTIZACION).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_COTIZACION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.COTIZACION COTIZACION)
        {
            AZMED_CLINICA.COTIZACIONES.Remove(COTIZACION);
        }

    }
}
