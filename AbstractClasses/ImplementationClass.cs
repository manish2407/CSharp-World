using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class ImplementationClass : AbstractClasses
    {
        public override void Mul(int FirstNum, int SecondNum)
        {
            Console.WriteLine(FirstNum * SecondNum);
        }
        public override void Div(int FirstNum, int SecondNum)
        {
            Console.WriteLine(FirstNum / SecondNum);
        }

        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            AbstractClasses obj1 = obj;
            obj1.Add(10, 10);
            obj.Add(20, 10);
            obj.Sub(20, 10);
            obj.Mul(20, 10);
            obj.Div(20, 10);
            Console.ReadLine();

        }
    }
}
