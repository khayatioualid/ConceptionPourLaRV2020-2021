using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    interface ICalculateur
    {
        int somme(int x, int y);
        int produit(int x, int y);
    }
}
