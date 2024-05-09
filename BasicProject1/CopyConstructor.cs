using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassAndConstructor
{
    internal class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            x = i;
            Console.WriteLine("Parameterised constructor is called " + i);
        }

        public CopyConstructor(CopyConstructor obj1)
        {
            x = obj1.x;
        }
        public void DisplayValue()
        {
            Console.WriteLine("Value of x is:" + x);
        }
        static void Main()
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            CopyConstructor obj2 = new CopyConstructor(obj1);
            // obj1.DisplayValue();
            obj2.DisplayValue();
            Console.ReadLine();
        }
    }
}
