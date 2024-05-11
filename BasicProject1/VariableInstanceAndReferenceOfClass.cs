using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassAndConstructor
{
    public class VariableInstanceAndReferenceOfClass
    {
        int x = 100;
        static void Main(string[] args)
        {
            VariableInstanceAndReferenceOfClass obj;   //variable of class
            obj = new VariableInstanceAndReferenceOfClass();  //Instance of class
            VariableInstanceAndReferenceOfClass obj2 = obj;
            Console.WriteLine(obj2.x);
            Console.WriteLine(obj.x);
            Console.ReadLine();
        }
    }
}
