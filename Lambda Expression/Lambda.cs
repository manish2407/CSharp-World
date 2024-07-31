using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    public class Lambda
    {
        public delegate string SayDelegate(string name);
        public string SayMessage(string name)
        {
            return "Hello " + name + " Good Morning!";
        }
        static void Main(string[] args)
        {
            Lambda am = new Lambda();
            String s = am.SayMessage("Manish");
            Console.WriteLine(s);

            Console.WriteLine("After creation of delegate");
            SayDelegate sd = am.SayMessage;
            string str = sd.Invoke("Scott");
            Console.WriteLine(str);

            Console.WriteLine("Using Lambda Expression");
            SayDelegate sd1 = (name) =>
            {
                return "Hello " + name + " Good Morning!";
            };
            string str1 = sd1.Invoke("John Snow");
            Console.WriteLine(str1);
            Console.ReadLine();

        }
    }
}
