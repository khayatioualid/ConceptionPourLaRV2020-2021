using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ArtDecoFactory:FabriqueAbstraite
    {
        public override Chair CreateChair()
        {
            return new ChairArtDeco();
        }
        public override Sofa CreateSofa()
        {
            return new SofaArtDeco();
        }
    }
}
