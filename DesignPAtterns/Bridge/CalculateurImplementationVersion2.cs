using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CalculateurImplementationVersion2 : ICalculateur
    {
        public int produit(int x, int y)
        {
            return x*y;
        }

        public int somme(int x, int y)
        {
            return x + y;
        }
    }
}
