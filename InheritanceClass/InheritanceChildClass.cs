using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class InheritanceChildClass : InheritanceClass
    {
        public InheritanceChildClass(int x) : base(100)
        {
            Console.WriteLine("Child Class Constructor is called");
            Console.WriteLine("Value of X is " + x);
        }
        public void Function3()
        {
            Console.WriteLine("Function 3 called");
        }
        static void Main(string[] args)
        {
            /*InheritanceChildClass obj = new InheritanceChildClass();
            obj.Function1();
            obj.Function2();
            obj.Function3();*/

            /*InheritanceClass obj;
            InheritanceChildClass obj2 = new InheritanceChildClass();
            obj = obj2;
            obj.Function1();
            obj.Function2();*/

            InheritanceChildClass obj = new InheritanceChildClass(10);
            Console.ReadLine();
        }
    }
}
