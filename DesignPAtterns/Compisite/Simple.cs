using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Simple : Composant
    {
        public Simple(string name, float poids) : base(name, poids)
        {
            this.composants = null;
        }
        public override void ajouterComposant(Composant composant)
        {
            throw new NotImplementedException();
        }

        public override float calculerPoids()
        {
            return poids;
        }

        public override void retirerComposant(Composant composant)
        {
            throw new NotImplementedException();
        }
    }
}
