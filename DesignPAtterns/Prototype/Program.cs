using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne() { nom = "walid" };
            Personne p2 = (Personne)p1.Dupliquer();
            p2.affiche();
            Console.ReadLine();
        }
    }
}
