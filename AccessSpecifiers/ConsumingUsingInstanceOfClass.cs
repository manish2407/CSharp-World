using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    //Case 3: Consuming members of class from non-child class of same project using instance of class
    public class ConsumingUsingInstanceOfClass
    {
        static void Main(string[] args)
        {
            AccessSpecifiersClass obj = new AccessSpecifiersClass();
            obj.Function2();
            obj.Function4();
            obj.Function5();
            Console.ReadLine();
        }
    }
}
