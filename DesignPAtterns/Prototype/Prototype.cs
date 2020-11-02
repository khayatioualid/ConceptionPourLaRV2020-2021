using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Prototype
    {
        public virtual void affiche()
        {
            Console.WriteLine("affiche de prototype.");
        }
        public Prototype Dupliquer()
        {
            Console.WriteLine("implementation standard qui retourne null.");
            return null;
        } 
    }
}
