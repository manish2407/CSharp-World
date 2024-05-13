using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class OverLoading
    {
        public void Function1()
        {
            Console.WriteLine("First method called");
        }
        public void Function2(int i)
        {
            Console.WriteLine("Second method called");
        }
        public void Function3(string s)
        {
            Console.WriteLine("Third method called");
        }
        public void Function4(int i, string s) {
            Console.WriteLine("Fourth method called");
        }

        public void Function5(string s, int i)
        {
            Console.WriteLine("Fifth method called");
        }
        static void Main(string[] args)
        {
            OverLoading obj = new OverLoading();
            obj.Function1 ();
            obj.Function2(100);
            obj.Function3("hello");
            obj.Function4(100, "hello");
            obj.Function5("hello", 100);
            Console.ReadLine();
        }
    }
}
