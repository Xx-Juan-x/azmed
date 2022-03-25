using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class LISTA_DE_PEDIDOS
    {
        // PATRON SINGLETON
        private static LISTA_DE_PEDIDOS instancia;

        public static LISTA_DE_PEDIDOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new LISTA_DE_PEDIDOS();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private LISTA_DE_PEDIDOS()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_LISTA_PEDIDO(MODELO.LISTA_PEDIDO LISTA_PEDIDO)
        {
            CASOS_DE_USO.LISTA_DE_PEDIDOS.OPERACIONES_LISTA_PEDIDOS.AGREGAR_LISTA_PEDIDO(oCONTEXTO, LISTA_PEDIDO);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_LISTA_PEDIDO(MODELO.LISTA_PEDIDO LISTA_PEDIDO)
        {
            CASOS_DE_USO.LISTA_DE_PEDIDOS.OPERACIONES_LISTA_PEDIDOS.MODIFICAR_LISTA_PEDIDO(oCONTEXTO, LISTA_PEDIDO);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_LISTA_PEDIDO(MODELO.LISTA_PEDIDO LISTA_PEDIDO)
        {
            CASOS_DE_USO.LISTA_DE_PEDIDOS.OPERACIONES_LISTA_PEDIDOS.ELIMINAR_LISTA_PEDIDO(oCONTEXTO, LISTA_PEDIDO);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.LISTA_PEDIDO OBTENER_LISTA_PEDIDO(int CODIGO)
        {
            return CASOS_DE_USO.LISTA_DE_PEDIDOS.GESTION_LISTA_PEDIDOS.OBTENER_LISTA_PEDIDO(CODIGO, oCONTEXTO);
        }

        public List<MODELO.LISTA_PEDIDO> OBTENER_LISTA_PEDIDOS()
        {
            return CASOS_DE_USO.LISTA_DE_PEDIDOS.GESTION_LISTA_PEDIDOS.OBTENER_LISTA_PEDIDOS(oCONTEXTO);
        }
    }
}
