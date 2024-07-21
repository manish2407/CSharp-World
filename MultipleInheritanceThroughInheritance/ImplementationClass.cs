using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceThroughInheritance
{
    public class ImplementationClass :ITestInterface1,ITestInterface2
    {
        public void Test() {
            Console.WriteLine("Interface method implemented in Implentation class");
        }
        //We can also implement interface method separately for both interface
        void ITestInterface1.Show()
        {
            Console.WriteLine("Method called for Interface 1");
        }
        void ITestInterface2.Show()
        {
            Console.WriteLine("Method called for Interface 2");
        }
        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            ITestInterface1 obj1 = obj;
            ITestInterface2 obj2 = obj;

            obj1.Show();
            obj2.Show();
            obj.Test();

            Console.ReadLine();
        }
    }
}
