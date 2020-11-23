using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Composant
    {
        public string name;
        public float poids;
        public Composant(string name,float poids)
        {
            this.name = name;
            this.poids = poids;
            this.composants = new List<Composant>();
        }
        public List<Composant> composants;
        public abstract void ajouterComposant(Composant composant);
        public abstract void retirerComposant(Composant composant);
        public abstract float calculerPoids();
    }
}
