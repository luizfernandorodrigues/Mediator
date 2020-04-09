using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Colega
    {
        protected Mediador mediador;

        public Colega(Mediador mediador)
        {
            this.mediador = mediador;
        }
    }
}
