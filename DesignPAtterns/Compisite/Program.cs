using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite n1 = new Composite("n1",1);
            Composite n21 = new Composite("n21", 5);
            Composite n22 = new Composite("n22",5 );
            Composite n23 = new Composite("n23",5);
            Composite n31 = new Composite("n31", 5);
            Composite n32 = new Composite("n32", 5);
            Composite n41 = new Composite("n41", 5);
            n1.ajouterComposant(n21); n1.ajouterComposant(n22); n1.ajouterComposant(n23);
            n22.ajouterComposant(n31); n22.ajouterComposant(n32);
            n32.ajouterComposant(n41);

            Console.WriteLine("n1.calculerPoids()="+n1.calculerPoids());
            Console.WriteLine("n22.calculerPoids()=" + n22.calculerPoids());
            Console.ReadLine();
        }
    }
}
