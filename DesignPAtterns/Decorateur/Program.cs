using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Program
    {
        static void Main(string[] args)
        {
            // version de base
            IComponent composant = new ConcreteComponent();
            composant.dessiner("version de base");

            Console.WriteLine("------------------------");
            // version avec decorateur 1
            IComponent composant1 = new DecorateurConcret1( new ConcreteComponent());
            composant1.dessiner("version de base");
            Console.WriteLine("------------------------");
            // version avec decorateur 2
            IComponent composant2 = new DecorateurConret2(new DecorateurConcret1(new ConcreteComponent()));
            composant2.dessiner("version de base");

            Console.ReadLine();

        }
    }
}
