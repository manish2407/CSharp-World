using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    //Case 2: Consuming members of class from child class of same project using Inheritance
    public class ConsumingMemberUsingInheritance : AccessSpecifiersClass
    {
        static void Main(string[] args)
        {
            ConsumingMemberUsingInheritance obj = new ConsumingMemberUsingInheritance();
            obj.Function2();
            obj.Function3();
            obj.Function4();
            obj.Function5();
            Console.ReadLine();

        }
    }
}
