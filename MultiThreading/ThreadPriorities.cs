using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{

    public class ThreadPriorities
    {
        static long count1, count2;
        public static void Increment() {
            while (true)
            {
                count1 += 1;
            }
        }
        public static void Increment2()
        {
            while (true)
            {
                count2 += 1;
            }
        }
        public static void Main(string[] args) {
            Thread T1 = new Thread(Increment);
            Thread T2 = new Thread(Increment2);
            T1.Priority = ThreadPriority.Lowest;
            T2.Priority = ThreadPriority.Highest;
            T1.Start();
            T2.Start();

            Console.WriteLine("Main Thread going to Sleep");
            Thread.Sleep(1000);
            Console.WriteLine("Main Thread Woke up");

            T1.Abort();
            T2.Abort();

            T1.Join();
            T2.Join();

            Console.WriteLine("Count1 is : " + count1);
            Console.WriteLine("Count2 is : " + count2);
            Console.ReadLine();
        }
    }
}
