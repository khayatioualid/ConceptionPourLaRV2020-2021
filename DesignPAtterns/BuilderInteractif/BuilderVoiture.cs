using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BuilderVoiture:AbstractBuilder
    {
        private string TypeChassis;
        private string TypeMoteur;
        private string TypeRoue;
        public override void ConstruireChassis(String TypeChassis)
        {
            Console.WriteLine("construction chassis de type "+TypeChassis);
            this.TypeChassis= TypeChassis;
        }
        public override void ConstruireMoteur(String TypeMoteur)
        {
            Console.WriteLine("construction moteur de type "+TypeMoteur);
            this.TypeMoteur= TypeMoteur;
        }
        public override void ConstruireRoue(String TypeRoue)
        {
            Console.WriteLine("construction roue de type "+TypeRoue);
            this.TypeRoue= TypeRoue;
        }
        public override AbstractVoiture getVoiture()
        {
            return new Voiture() { TypeChassis = this.TypeChassis, TypeMoteur = this.TypeMoteur, TypeRoue = this.TypeRoue };
            
        }
    }
}
