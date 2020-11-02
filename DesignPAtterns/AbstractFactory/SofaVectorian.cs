using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SofaVectorian:Sofa
    {
        public override void affiche()
        {
            Console.WriteLine("Je suis SofaVectorian");
        }
    }
}
