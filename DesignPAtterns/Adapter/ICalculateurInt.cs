using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface ICalculateurInt
    {
        int somme(int x, int y);
        int produit(int x, int y);
    }
}
