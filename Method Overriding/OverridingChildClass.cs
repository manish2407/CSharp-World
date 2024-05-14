using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class OverridingChildClass : Overriding
    {
        public void show(int i){
            Console.WriteLine("Child's show method is called");
        }

        public  void Test(string s)
        {
           Console.WriteLine("Child's test method is called");
        }

        public override void OverridingFuntion()
        {
            Console.WriteLine("Child's overridden method is called");
        }
        static void Main(string[] args)
        {

            OverridingChildClass obj = new OverridingChildClass();
            obj.show();
            obj.show(2);
            obj.Test();
            obj.Test("hello");
            obj.OverridingFuntion();
            Console.ReadLine();
        }
    }
}
