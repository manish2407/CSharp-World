using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //using delegate
    public delegate void AddDelegate(int num1, int num2);
    public delegate string SayDelegate(string msg);
    public class Program
    {
        public void AddNumber(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Sum is : " + sum);
        }
        public static string SayHello(string msg)
        {
            return "Hello " + msg;
        }
        static void Main(string[] args)
        {
            Program instance = new Program();
            instance.AddNumber(1, 2);
            //instantiation of Delegate
            AddDelegate obj = new AddDelegate(instance.AddNumber);
            SayDelegate obj1 = new SayDelegate(SayHello);
            // or we can instance like SayDelegate obj1 = new SayDelegate(SayHello);
            //calling the delegate
            obj.Invoke(100, 100);
            obj(100, 200);
            string str = obj1.Invoke("John");
            string str1 = obj1("Bayes");
            string s = Program.SayHello("Manish");
            Console.WriteLine(s);
            Console.WriteLine(str);
            Console.WriteLine(str1);

            Console.ReadLine();
        }
    }
}
