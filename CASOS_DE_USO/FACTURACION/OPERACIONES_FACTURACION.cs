using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.FACTURACION
{
    public class OPERACIONES_FACTURACION
    {
        public static void AGREGAR_FACTURACION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.FACTURACION FACTURACION)
        {
            AZMED_CLINICA.FACTURACION.Add(FACTURACION);
        }

        public static void MODIFICAR_FACTURACION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.FACTURACION FACTURACION)
        {
            AZMED_CLINICA.Entry(FACTURACION).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_FACTURACION(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.FACTURACION FACTURACION)
        {
            AZMED_CLINICA.FACTURACION.Remove(FACTURACION);
        }

    }
}
