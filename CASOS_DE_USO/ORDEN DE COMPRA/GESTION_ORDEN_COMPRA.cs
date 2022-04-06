using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.ORDEN_DE_COMPRA
{
    public class GESTION_ORDEN_COMPRA
    {
        public static MODELO.ORDEN_COMPRA OBTENER_ORDEN_COMPRA(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.ORDENES_DE_COMPRAS.Include("PEDIDO").FirstOrDefault(_ => _.ID_ORDEN_COMPRA == CODIGO);
        }

        public static List<MODELO.ORDEN_COMPRA> OBTENER_ORDENES_COMPRAS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.ORDENES_DE_COMPRAS.Include("PEDIDO").ToList();
        }
    }
}
