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
            AbstractVoiture v = builder.getVoiture("chassis 1", "moteur 1", "roue1");
            v.conduire();
        }
    }
}
