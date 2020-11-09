using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 5.5f;
            float y = 10.1f;
            CalculateurFloat calc = new CalculateurFloat();
            float sommeFloat = calc.somme(x, y);
            Console.WriteLine("sommeFloat="+sommeFloat);
            int x1 = 5;
            int y1 = 10;
            ICalculateurInt calc1 = new CalculateurInt(new CalculateurFloat());
            int sommeInt = calc1.somme(x1, y1);
            Console.WriteLine("sommeInt="+sommeInt);
            Console.ReadLine();
        }
    }
}
