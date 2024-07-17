using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class ImplementationClass:ITestInterface2
    {
        //We can also call the Interface method by using Interface name
        void ITest_Interface1.Add(int a, int b) { }

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            //To create the reference of an interface 

            ITestInterface2 test = obj;
            ITest_Interface1 test1 = obj;
            obj.Add(10, 2);
            obj.Sub(10, 2);
            // We can also call the method with the reference of interface
            test.Sub(80, 20);
            test1.Add(80, 20);
            Console.ReadLine();
        }
    }
}
