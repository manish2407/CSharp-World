using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject1
{
    // 2. Default/Implicit Constructor program
    internal class ConstructorProgram
    {
        int num1;
        string str;
        bool boolVariable;
        static void Main(string[] args)
        {
            ConstructorProgram obj = new ConstructorProgram();
            Console.WriteLine(obj.num1);
            Console.WriteLine(obj.str);
            Console.WriteLine(obj.boolVariable);

            Console.ReadLine();
        }
    }
}
