using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    //Case 1: Consuming members of class from same class
    public class AccessSpecifiersClass
    {
        private void Function1()
        {
            Console.WriteLine("Private function called");
        }
        internal void Function2()
        {
            Console.WriteLine("internal function called");
        }
        protected void Function3()
        {
            Console.WriteLine("protected function called");
        }
        protected internal void Function4()
        {
            Console.WriteLine("protected internal function called");
        }
        public void Function5()
        {
            Console.WriteLine("public function called");
        }
        static void Main(string[] args)
        {
            AccessSpecifiersClass obj = new AccessSpecifiersClass();
            obj.Function1();
            obj.Function2();
            obj.Function3();
            obj.Function4();
            obj.Function5();
            Console.ReadLine();
        }
    }
}
