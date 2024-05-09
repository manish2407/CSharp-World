using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassAndConstructor
{
    internal class ParameterisedConstructor
    {
        int x;
        public ParameterisedConstructor(int i)
        {
            x = i;
            Console.WriteLine("Parameterised constructor is called " + i);
        }
        public void DisplayValue() {
            Console.WriteLine("Value of x is:" + x);
        } 
        static void Main()
        {
            ParameterisedConstructor obj1 = new ParameterisedConstructor(10);
            ParameterisedConstructor obj2 = new ParameterisedConstructor(20);
            obj1.DisplayValue();
            obj2.DisplayValue();
            Console.ReadLine();
        } 
    }
}
