using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class OperatorOverloading
    {
        public void Function1(int x, int y)
        {
            int z = x + y;
            Console.WriteLine(z);
        }
        public void Function2(string s1, string s2)
        {
            string str = s1 + s2;
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            OperatorOverloading obj = new OperatorOverloading();
            obj.Function1(10, 20);
            obj.Function2("Hello", "C#");
            Console.ReadLine();
        }
    }
}
