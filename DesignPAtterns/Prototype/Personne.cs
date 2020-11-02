using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Personne : Prototype
    {
        public string nom;
        public override void affiche()
        {
            Console.WriteLine(" Personne : " + nom);
        }
        public new Prototype Dupliquer()
        {
            Console.WriteLine("implementation dans Personne.");
            return new Personne() { nom = this.nom };
        }
    }
}
