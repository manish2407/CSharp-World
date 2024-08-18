using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    static class StaticClass
    {   //extension method
        public static void Method3(this ExtenstionMethods e)
        {
            Console.WriteLine("Method 3 called");
        }
        //extension method with same name as original method
        /*public static void Method2(this ExtenstionMethods e)
        {
            Console.WriteLine("Method 3 called");
        }*/
        public static long factorial(this Int32 x)
{
    if (x == 1)
        return 1;
    if (x == 2)
        return 2;
    else
        return x * factorial(x - 1);

}
}
}
