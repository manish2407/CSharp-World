using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class AbstractClasses
    {
        public void Add(int FirstNum, int SecondNum) {
            Console.WriteLine(FirstNum + SecondNum);
        }
        public void Sub(int FirstNum, int SecondNum)
        {
            Console.WriteLine(FirstNum - SecondNum);
        }
        public abstract void Mul(int FirstNum, int SecondNum);
        public abstract void Div(int FirstNum, int SecondNum);
    }
}
