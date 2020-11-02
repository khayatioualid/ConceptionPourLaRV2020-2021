using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BuilderVoiture:AbstractBuilder
    {
        public string ConstruireChassis(String TypeChassis)
        {
            Console.WriteLine("construction chassis de type "+TypeChassis);
            return TypeChassis;
        }
        public string ConstruireMoteur(String TypeMoteur)
        {
            Console.WriteLine("construction moteur de type "+TypeMoteur);
            return TypeMoteur;
        }
        public string ConstruireRoue(String TypeRoue)
        {
            Console.WriteLine("construction roue de type "+TypeRoue);
            return TypeRoue;
        }
        public override AbstractVoiture getVoiture(String TypeChassis, String TypeMoteur, String TypeRoue)
        {
            string ch=ConstruireChassis(TypeChassis);
            string mo=ConstruireMoteur(TypeMoteur);
            string ro=ConstruireRoue(TypeRoue);
            return new Voiture() { TypeChassis = ch, TypeMoteur = mo, TypeRoue = ro };
            
        }
    }
}
