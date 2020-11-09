using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    public abstract class Decorator : IComponent
    {
        protected IComponent next;
        public Decorator(IComponent next)
        {
            this.next = next;
        }

        public abstract void dessiner(string message);
    }
}
