using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ChairArtDeco : Chair
    {
        public override void affiche()
        {
            Console.WriteLine("Je suis ChairArtDeco");
        }
    }
}
