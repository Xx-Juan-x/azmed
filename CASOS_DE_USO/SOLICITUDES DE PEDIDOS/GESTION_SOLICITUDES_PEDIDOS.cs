using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.SOLICITUDES_DE_PEDIDOS
{
    public class GESTION_SOLICITUDES_PEDIDOS
    {
        public static MODELO.SOLICITUD_PEDIDO OBTENER_SOLICITUD_PEDIDO(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.SOLICITUDES_DE_PEDIDO.FirstOrDefault(_ => _.ID_SOLICITUD_PEDIDO == CODIGO);
        }

        public static List<MODELO.SOLICITUD_PEDIDO> OBTENER_SOLICITUDES_PEDIDOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.SOLICITUDES_DE_PEDIDO.ToList();
        }

    }
}
