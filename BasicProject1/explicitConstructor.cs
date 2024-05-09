using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassAndConstructor
{
    // 3. Explicit Constructor program structor
    internal class explicitConstructor
    {
        public explicitConstructor() {
            Console.WriteLine("Constructor is called");
        }

        static void Main(string[] args)
        {
            explicitConstructor obj = new explicitConstructor();
            explicitConstructor obj2 = new explicitConstructor();
            explicitConstructor obj3 = new explicitConstructor();
            Console.ReadLine();
        }
    }
}
