using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class DecorateurConcret1 : Decorator
    {
        public DecorateurConcret1(IComponent next) : base(next)
        {

        }
        public override void dessiner(string message)
        {
            Console.WriteLine("pre-traitement DecorateurConret1");
            next.dessiner(message);
            Console.WriteLine("post-traitement DecorateurConret1");
        }
    }
}
