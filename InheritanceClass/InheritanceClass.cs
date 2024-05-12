using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class InheritanceClass
    {
        public InheritanceClass(int y)
        {
            Console.WriteLine("Parent class Constructor is called");
            Console.WriteLine("Value of Y is " + y);
        }
        public void Function1() {
            Console.WriteLine("Function 1 called");
        }
        public void Function2()
        {
            Console.WriteLine("Function 2 called");
        }
        
    }
}
