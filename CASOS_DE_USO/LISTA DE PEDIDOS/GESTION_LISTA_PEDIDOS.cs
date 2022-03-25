using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.LISTA_DE_PEDIDOS
{
    public class GESTION_LISTA_PEDIDOS
    {
        public static MODELO.LISTA_PEDIDO OBTENER_LISTA_PEDIDO(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.LISTA_DE_PEDIDOS.Include("INSUMO").Include("PEDIDO").FirstOrDefault(_ => _.ID_LISTA_PEDIDO == CODIGO);
        }

        public static List<MODELO.LISTA_PEDIDO> OBTENER_LISTA_PEDIDOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.LISTA_DE_PEDIDOS.Include("INSUMO").Include("PEDIDO").ToList();
        }

    }
}
