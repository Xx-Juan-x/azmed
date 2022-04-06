using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.LISTA_DE_ORDEN_DE_COMPRAS
{
    public class GESTION_LISTA_COMPRAS
    {
        public static MODELO.LISTA_COMPRA OBTENER_LISTA_ORDEN_COMPRA(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        { 
            return AZMED_CLINICA.LISTA_DE_COMPRAS.Include("COMPRA").Include("COTIZACION").FirstOrDefault(_ => _.ID_LISTA_COMPRA == CODIGO);
        }

        public static List<MODELO.LISTA_COMPRA> OBTENER_LISTA_ORDEN_COMPRAS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.LISTA_DE_COMPRAS.Include("COMPRA").Include("COTIZACION").ToList();
        }
    }
}
