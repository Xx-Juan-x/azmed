﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISTA.State
{
    public class Context
    {
        // A reference to the current state of the Context.
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void TransitionTo(State state)
        {
            this._state = state;
            this._state.SetContext(this);
        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void Request1(MODELO.SOLICITUD_PEDIDO solicitud)
        {
            this._state.Handle1(solicitud);
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }
}
