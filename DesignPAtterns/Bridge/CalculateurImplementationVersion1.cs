using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CalculateurImplementationVersion1 : ICalculateur
    {
        public int produit(int x, int y)
        {
            int s = 0;
            for (int i = 0; i < x; i++)
            {
                s = somme(y, s);
            }
            return s;
        }

        public int somme(int x, int y)
        {
            return x + y;
        }
    }
}
