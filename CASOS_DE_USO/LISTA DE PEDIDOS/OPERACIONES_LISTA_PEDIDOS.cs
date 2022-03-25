using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.LISTA_DE_PEDIDOS
{
    public class OPERACIONES_LISTA_PEDIDOS
    {
        public static void AGREGAR_LISTA_PEDIDO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.LISTA_PEDIDO LISTA_PEDIDO)
        {
            AZMED_CLINICA.LISTA_DE_PEDIDOS.Add(LISTA_PEDIDO);
        }

        public static void MODIFICAR_LISTA_PEDIDO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.LISTA_PEDIDO LISTA_PEDIDO)
        {
            AZMED_CLINICA.Entry(LISTA_PEDIDO).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_LISTA_PEDIDO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.LISTA_PEDIDO LISTA_PEDIDO)
        {
            AZMED_CLINICA.LISTA_DE_PEDIDOS.Remove(LISTA_PEDIDO);
        }
    }
}
