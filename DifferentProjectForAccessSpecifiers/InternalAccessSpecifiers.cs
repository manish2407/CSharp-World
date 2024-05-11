using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentProjectForAccessSpecifiers
{
    //Case 4: Consuming members of class from child class of different project using Inheritance
    internal class InternalAccessSpecifiers : AccessSpecifiers.AccessSpecifiersClass
    {
        static void Main(string[] args)
        {
            InternalAccessSpecifiers obj = new InternalAccessSpecifiers();
            obj.Function3();
            obj. Function4();
            obj. Function5(); 

            Console.ReadLine();
        }
    }
}
