using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    public class TestExtClass
    {
        public static void Main(string[] args)
        {   //extension method
            /*ExtenstionMethods ext = new ExtenstionMethods();
            ext.Method1();
            ext.Method2();
            ext.Method3();*/

            //extension method with same name as original name
            ExtenstionMethods ext = new ExtenstionMethods();
            ext.Method1();
            ext.Method2();
            ext.Method3();
            int i = 5;
            long result = i.factorial();
            Console.WriteLine("factorial of " + i + " is "+ result);
            Console.ReadLine();
        }
    }
}
