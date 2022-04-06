using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.LISTA_DE_ORDEN_DE_COMPRAS
{
    public class OPERACIONES_LISTA_COMPRAS
    {
        public static void AGREGAR_LISTA_ORDEN_COMPRA(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.LISTA_COMPRA LISTA_COMPRA)
        {
            AZMED_CLINICA.LISTA_DE_COMPRAS.Add(LISTA_COMPRA);
        }

        public static void MODIFICAR_LISTA_ORDEN_COMPRA(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.LISTA_COMPRA LISTA_COMPRA)
        {
            AZMED_CLINICA.Entry(LISTA_COMPRA).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_LISTA_ORDEN_COMPRA(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.LISTA_COMPRA LISTA_COMPRA)
        {
            AZMED_CLINICA.LISTA_DE_COMPRAS.Remove(LISTA_COMPRA);
        }
    }
}
