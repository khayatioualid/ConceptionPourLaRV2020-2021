using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite : Composant
    {
        public Composite(string name, float poids):base(name,poids)
        {
        }
        public override void ajouterComposant(Composant composant)
        {
            composants.Add(composant);
        }

        public override void retirerComposant(Composant composant)
        {
            composants.Remove(composant);
        }
        public override float calculerPoids()
        {
            float result = poids;
            foreach (Composant composant in composants)
            {
                result = result + composant.calculerPoids();
            }
            return result;
        }
    }
}
