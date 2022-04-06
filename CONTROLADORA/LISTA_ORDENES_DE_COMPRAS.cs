using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class LISTA_ORDENES_DE_COMPRAS
    {
        // PATRON SINGLETON
        private static LISTA_ORDENES_DE_COMPRAS instancia;

        public static LISTA_ORDENES_DE_COMPRAS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new LISTA_ORDENES_DE_COMPRAS();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private LISTA_ORDENES_DE_COMPRAS()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_LISTA_ORDEN_COMPRA(MODELO.LISTA_COMPRA LISTA_COMPRA)
        {
            CASOS_DE_USO.LISTA_DE_ORDEN_DE_COMPRAS.OPERACIONES_LISTA_COMPRAS.AGREGAR_LISTA_ORDEN_COMPRA(oCONTEXTO, LISTA_COMPRA);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_LISTA_ORDEN_COMPRA(MODELO.LISTA_COMPRA LISTA_COMPRA)
        {
            CASOS_DE_USO.LISTA_DE_ORDEN_DE_COMPRAS.OPERACIONES_LISTA_COMPRAS.MODIFICAR_LISTA_ORDEN_COMPRA(oCONTEXTO, LISTA_COMPRA);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_LISTA_ORDEN_COMPRA(MODELO.LISTA_COMPRA LISTA_COMPRA)
        {
            CASOS_DE_USO.LISTA_DE_ORDEN_DE_COMPRAS.OPERACIONES_LISTA_COMPRAS.ELIMINAR_LISTA_ORDEN_COMPRA(oCONTEXTO, LISTA_COMPRA);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.LISTA_COMPRA OBTENER_LISTA_COMPRA(int CODIGO)
        {
            return CASOS_DE_USO.LISTA_DE_ORDEN_DE_COMPRAS.GESTION_LISTA_COMPRAS.OBTENER_LISTA_ORDEN_COMPRA(CODIGO, oCONTEXTO);
        }

        public List<MODELO.LISTA_COMPRA> OBTENER_LISTA_COMPRAS()
        {
            return CASOS_DE_USO.LISTA_DE_ORDEN_DE_COMPRAS.GESTION_LISTA_COMPRAS.OBTENER_LISTA_ORDEN_COMPRAS(oCONTEXTO);
        }




    }
}
