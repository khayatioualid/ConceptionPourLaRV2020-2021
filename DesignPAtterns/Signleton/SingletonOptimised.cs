using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonOptimised
    {
        public int param1;
        public int param2;
        private static SingletonOptimised instance = new SingletonOptimised(1, 2);
        public static SingletonOptimised getInstance()
        {
            return instance;
        }
        private SingletonOptimised(int parm1, int param2)
        {
            this.param1 = param1;
            this.param2 = param2;
        }
    }
}
