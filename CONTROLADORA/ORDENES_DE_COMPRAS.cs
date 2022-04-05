using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ORDENES_DE_COMPRAS
    {
        // PATRON SINGLETON
        private static ORDENES_DE_COMPRAS instancia;

        public static ORDENES_DE_COMPRAS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new ORDENES_DE_COMPRAS();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private ORDENES_DE_COMPRAS()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_ORDEN_COMPRA(MODELO.ORDEN_COMPRA ORDEN_COMPRA)
        {
            CASOS_DE_USO.ORDEN_DE_COMPRA.OPERACIONES_ORDEN_COMPRA.AGREGAR_ORDEN_COMPRA(oCONTEXTO, ORDEN_COMPRA);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_ORDEN_COMPRA(MODELO.ORDEN_COMPRA ORDEN_COMPRA)
        {
            CASOS_DE_USO.ORDEN_DE_COMPRA.OPERACIONES_ORDEN_COMPRA.MODIFICAR_ORDEN_COMPRA(oCONTEXTO, ORDEN_COMPRA);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_ORDEN_COMPRA(MODELO.ORDEN_COMPRA ORDEN_COMPRA)
        {
            CASOS_DE_USO.ORDEN_DE_COMPRA.OPERACIONES_ORDEN_COMPRA.ELIMINAR_ORDEN_COMPRA(oCONTEXTO, ORDEN_COMPRA);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.ORDEN_COMPRA OBTENER_ORDEN_COMPRA(int CODIGO)
        {
            return CASOS_DE_USO.ORDEN_DE_COMPRA.GESTION_ORDEN_COMPRA.OBTENER_ORDEN_COMPRA(CODIGO, oCONTEXTO);
        }

        public List<MODELO.ORDEN_COMPRA> OBTENER_ORDENES_COMPRAS()
        {
            return CASOS_DE_USO.ORDEN_DE_COMPRA.GESTION_ORDEN_COMPRA.OBTENER_ORDENES_COMPRAS(oCONTEXTO);
        }
    }
}
