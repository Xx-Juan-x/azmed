﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.SOLICITUDES_DE_PEDIDOS
{
    public class OPERACIONES_SOLICITUDES_PEDIDOS
    {
        public static void AGREGAR_SOLICITUD_PEDIDO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.SOLICITUD_PEDIDO SOLICITUD_PEDIDO)
        {
            AZMED_CLINICA.SOLICITUDES_DE_PEDIDO.Add(SOLICITUD_PEDIDO);
        }

        public static void MODIFICAR_SOLICITUD_PEDIDO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.SOLICITUD_PEDIDO SOLICITUD_PEDIDO)
        {
            AZMED_CLINICA.Entry(SOLICITUD_PEDIDO).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_SOLICITUD_PEDIDO(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.SOLICITUD_PEDIDO SOLICITUD_PEDIDO)
        {
            AZMED_CLINICA.SOLICITUDES_DE_PEDIDO.Remove(SOLICITUD_PEDIDO);
        }
    }
}
