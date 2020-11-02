using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class AbstractBuilder
    {
        public abstract void ConstruireChassis(String TypeChassis);
        public abstract void ConstruireMoteur(String TypeMoteur);
        public abstract void ConstruireRoue(String TypeRoue);
        public abstract AbstractVoiture getVoiture();
    }
}
