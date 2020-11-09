using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CalculateurInt : ICalculateurInt
    {
        CalculateurFloat adapted;
        public CalculateurInt(CalculateurFloat adapted)
        {
            this.adapted = adapted;
        }
        public int produit(int x, int y)
        {
            return (int)adapted.produit((float)x,(float)y);
        }

        public int somme(int x, int y)
        {
            return (int)adapted.somme((float)x, (float)y);
        }
    }
}
