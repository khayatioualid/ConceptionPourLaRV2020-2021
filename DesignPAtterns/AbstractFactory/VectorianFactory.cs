using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VectorianFactory : FabriqueAbstraite
    {
        public override Chair CreateChair()
        {
            return new ChairVectorian();
        }
        public override Sofa CreateSofa()
        {
            return new SofaVectorian();
        }
    }
}
