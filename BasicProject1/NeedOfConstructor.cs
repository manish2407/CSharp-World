using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassAndConstructor
{
    public class NeedOfConstructor
    {
       public int x = 10;
    }

    public class ExplicitConstructor
    {
        public int y;
        public ExplicitConstructor(int y)
        {
            this.y = y;
        }
    }
    public class ExecutionClass
    {
        static void Main() { 
            NeedOfConstructor obj = new NeedOfConstructor();
            NeedOfConstructor obj1 = new NeedOfConstructor();
            Console.WriteLine(obj.x + " " + obj1.x);

            ExplicitConstructor obj2 = new ExplicitConstructor(100);
            ExplicitConstructor obj3 = new ExplicitConstructor(200);

            Console.WriteLine(obj3.y + " " + obj3.y);
            Console.ReadLine();
        }
    }
}
