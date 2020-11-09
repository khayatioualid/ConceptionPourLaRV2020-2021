using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class ConcreteComponent : IComponent
    {
        public void dessiner(string message)
        {
            Console.WriteLine(message);
        }
    }
}
