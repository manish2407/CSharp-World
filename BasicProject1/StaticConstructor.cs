using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassAndConstructor
{
    internal class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor is called");
        }
        public StaticConstructor() {
            Console.WriteLine("Explicit Constructor is called");
        }

        static void Main()
        {
            StaticConstructor obj1 = new StaticConstructor();
            Console.ReadLine();
        }
    }
}
