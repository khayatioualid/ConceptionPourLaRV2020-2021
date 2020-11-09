using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CalculateurFloat
    {
        public float somme(float x,float y)
        {
            return x + y;
        }
        public float produit(float x, float y)
        {
            return x * y;
        }
    }
}
