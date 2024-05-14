using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Overriding
    {
        public void show()
        {
            Console.WriteLine("Parent's show method is called");
        }

        public void Test()
        {
            Console.WriteLine("Parent's test method is called");
        }
        public virtual void OverridingFuntion()
        {
            Console.WriteLine("Parent's overridden method is called");
        }
    }  
}
