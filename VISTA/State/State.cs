using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISTA.State
{
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1(MODELO.SOLICITUD_PEDIDO solicitud);

        public abstract void Handle2();
    }
}
