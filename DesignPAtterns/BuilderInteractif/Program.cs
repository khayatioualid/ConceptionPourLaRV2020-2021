using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder builder = new BuilderVoiture();
            builder.ConstruireChassis("chassis1");
            builder.ConstruireMoteur("moteur1");
            builder.ConstruireRoue("roue1");
            AbstractVoiture v = builder.getVoiture();
            v.conduire();
            Console.ReadLine();
        }
    }
}
