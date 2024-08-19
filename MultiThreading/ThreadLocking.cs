using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class ThreadLocking
    {
        
    public void Display()
     {
        lock (this) {
                Console.Write("Hello All, I am ");
                Thread.Sleep(5000);
                Console.WriteLine("C#");
        }
     }
        public static void Main(String[] args)
        {
            ThreadLocking obj = new ThreadLocking();
            /*obj.Display();
            obj.Display();
            obj.Display();*/

            Thread T1 = new Thread(obj.Display);
            Thread T2 = new Thread(obj.Display);
            Thread T3 = new Thread(obj.Display);
            T1.Start();
            T2.Start();
            T3.Start();
            Console.ReadLine();
        }
    }
}
