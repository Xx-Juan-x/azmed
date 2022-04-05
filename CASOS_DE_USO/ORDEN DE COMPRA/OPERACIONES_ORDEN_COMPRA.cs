using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.ORDEN_DE_COMPRA
{
    public class OPERACIONES_ORDEN_COMPRA
    {
        public static void AGREGAR_ORDEN_COMPRA(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ORDEN_COMPRA ORDEN_COMPRA)
        {
            AZMED_CLINICA.ORDENES_DE_COMPRAS.Add(ORDEN_COMPRA);
        }

        public static void MODIFICAR_ORDEN_COMPRA(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ORDEN_COMPRA ORDEN_COMPRA)
        {
            AZMED_CLINICA.Entry(ORDEN_COMPRA).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_ORDEN_COMPRA(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.ORDEN_COMPRA ORDEN_COMPRA)
        {
            AZMED_CLINICA.ORDENES_DE_COMPRAS.Remove(ORDEN_COMPRA);
        }
    }
}
