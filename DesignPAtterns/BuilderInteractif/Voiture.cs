using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Voiture:AbstractVoiture
    {
        public string TypeMoteur, TypeChassis, TypeRoue;
        public override void conduire()
        {
            Console.WriteLine("coucou");
        }

    }
}
