using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            FabriqueVilles fab = new FabriqueVilles();
            Ville v1 = fab.GetVille("Tunis");
            Ville v2 = fab.GetVille("Nabeul");
            Ville v3 = fab.GetVille("Tunis");
            Console.ReadLine();
        }
    }
}
