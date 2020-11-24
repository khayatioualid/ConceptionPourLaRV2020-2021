using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class FabriqueVilles
    {
        public Dictionary<string, Ville> dictionnaire;
        public FabriqueVilles()
        {
            dictionnaire = new Dictionary<string, Ville>();
        }
        public Ville GetVille(string libelle)
        {
            if (dictionnaire.ContainsKey(libelle))
            {
                Console.WriteLine(" recuperation de " + libelle);
                return dictionnaire[libelle];
            }
            else
            {
                Console.WriteLine(" construction de " + libelle);
                Ville newVille=new Ville() { libelle = libelle };
                dictionnaire[libelle] = newVille;
                return newVille;
            }
            
        }
    }
}
