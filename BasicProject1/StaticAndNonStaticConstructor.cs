using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassAndConstructor
{
    public class StaticAndNonStaticConstructor
    {
        static int x;
        public int y;
        static StaticAndNonStaticConstructor()
        {
            Console.WriteLine("Static Constructor is called");
        }
        public StaticAndNonStaticConstructor()
        {
            
            Console.WriteLine("Non static constructor is called");
        }
        public StaticAndNonStaticConstructor(int y) {
            this.y = y;
            Console.WriteLine("Non static constructor is called");
        }
        
        static void Main()
        {
            StaticAndNonStaticConstructor obj = new StaticAndNonStaticConstructor();
            StaticAndNonStaticConstructor obj1 = new StaticAndNonStaticConstructor(100);
            Console.WriteLine(x);
            Console.WriteLine(obj1.y);
            Console.ReadLine();
        }
    }
}
