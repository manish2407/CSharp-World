using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    public class MethodHiding
    {
        public virtual void Function1()
        {
            Console.WriteLine("Function 1 is called");
        }

        public void Function2() {
            Console.WriteLine("Function 2 is called");
        }
    }

    class ChildClass : MethodHiding
    {
        public override void Function1()
        {
            Console.WriteLine("Parent's Function1 is overriden and Child class function 1 is called");
        }
        public new void Function2()
        {
            Console.WriteLine("Child Class Function 2 is called");
        }

        // Calling parent class methods using Base Keyword
        public void BaseFunction1()
        {
            base.Function1();
        }
        public void BaseFunction2()
        {
            base.Function2();
        }

        static void Main()
        {
            // 1. Calling parent class methods using Parent Class Object Creation
            MethodHiding obj1 = new MethodHiding();
            obj1.Function1();
            obj1.Function2();
            
            ChildClass obj = new ChildClass();
            obj.Function1();
            obj.Function2();
            //2. Calling parent class methods using Base Keyword
            obj.BaseFunction1();
            obj.BaseFunction2();
            Console.ReadLine();

        }
    }
}
