using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        public int param1;
        public int param2;
        private static Singleton instance = null;
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance= new Singleton(1, 2);
                Console.WriteLine("instanciation en cours.");
            }
            return instance;
        }
        private Singleton(int parm1, int param2)
        {
            this.param1 = param1;
            this.param2 = param2;
        }
    }
}
