using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICalculateur calc = new CalculateurInterface(new CalculateurImplementationVersion1());
            ICalculateur calc = new CalculateurInterface(new CalculateurImplementationVersion2());
            Console.WriteLine("5+10="+ calc.somme(5, 10));
            Console.ReadLine();
        }
    }
}
