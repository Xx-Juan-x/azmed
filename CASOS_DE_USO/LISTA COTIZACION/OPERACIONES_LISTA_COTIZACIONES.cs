using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.LISTA_COTIZACION
{
    public class OPERACIONES_LISTA_COTIZACIONES
    {
        public static void AGREGAR_LISTA_COTIZACION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.LISTA_COTIZACION LISTA_COTIZACION)
        {
            AZMED_CLINICA.LISTA_COTIZACION.Add(LISTA_COTIZACION);
        }

        public static void MODIFICAR_LISTA_COTIZACION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.LISTA_COTIZACION LISTA_COTIZACION)
        {
            AZMED_CLINICA.Entry(LISTA_COTIZACION).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_LISTA_COTIZACION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.LISTA_COTIZACION LISTA_COTIZACION)
        {
            AZMED_CLINICA.LISTA_COTIZACION.Remove(LISTA_COTIZACION);
        }
    }
}
