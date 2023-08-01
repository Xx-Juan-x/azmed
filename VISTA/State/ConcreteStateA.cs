using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.State
{
    public class ConcreteStateCotizar : State
    {
        private CONTROLADORA.SOLICITUDES_DE_PEDIDOS cSOLICITUD_PEDIDOS;
        public override void Handle1(MODELO.SOLICITUD_PEDIDO solicitud)
        {
            cSOLICITUD_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            solicitud.ESTADO = "EN COTIZACION";
            cSOLICITUD_PEDIDOS.MODIFICAR_SOLICITUD_PEDIDO(solicitud);
            MessageBox.Show("Estado de la solicitud modificada : EN COTIZACION");

            //"ConcreteStateA handles request1.";
            //"ConcreteStateA wants to change the state of the context.";
            this._context.TransitionTo(new ConcreteStateCompletado());
        }

        public override void Handle2()
        {
            
        }
    }
    public class ConcreteStateCompletado : State
    {
        private CONTROLADORA.SOLICITUDES_DE_PEDIDOS cSOLICITUD_PEDIDOS;

        public override void Handle1(MODELO.SOLICITUD_PEDIDO solicitud)
        {
            cSOLICITUD_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            solicitud.ESTADO = "COMPLETADO";
            cSOLICITUD_PEDIDOS.MODIFICAR_SOLICITUD_PEDIDO(solicitud);
            MessageBox.Show("Estado de la solicitud modificada : COMPLETADA");
            //"ConcreteStateB handles request1.";
        }

        public override void Handle2()
        {
            //"ConcreteStateB handles request2.";
            //"ConcreteStateB wants to change the state of the context.";
            this._context.TransitionTo(new ConcreteStateCotizar());
        }
    }
}
