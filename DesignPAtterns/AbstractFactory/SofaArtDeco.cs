using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SofaArtDeco : Sofa
    {
        public override void affiche()
        {
            Console.WriteLine("Je suis SofaArtDeco");
        }
    }
}
