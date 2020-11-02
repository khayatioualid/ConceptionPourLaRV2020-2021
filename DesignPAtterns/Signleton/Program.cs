using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //version classique
            Console.WriteLine("-----------------------------------");
            Singleton s1 = Singleton.getInstance();
            Console.WriteLine("-----------------------------------");
            Singleton s2 = Singleton.getInstance();
            Console.WriteLine("-----------------------------------");
            // version optimisée
            Console.WriteLine("-----------------------------------");
            SingletonOptimised s3 = SingletonOptimised.getInstance();
            Console.WriteLine("-----------------------------------");
            SingletonOptimised s4 = SingletonOptimised.getInstance();
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

        }
    }
}
