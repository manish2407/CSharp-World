using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class ThreadPerformance
    {
        public static void IncrementPerformance()
        {
            long count = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                count++;
            }
            Console.WriteLine("Count1 is :" + count);
        }
        public static void IncrementPerformance2()
        {
            long count1 = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                count1++;
            }
            Console.WriteLine("Count2 is :" + count1);
        }

        public static void Main(string[] args)
        {
            Thread T1 = new Thread(IncrementPerformance);
            Thread T2 = new Thread(IncrementPerformance2);
            Stopwatch s = new Stopwatch();
            Stopwatch s1 = new Stopwatch();
            s.Start();
            IncrementPerformance();
            IncrementPerformance2();
            s.Stop();

            s1.Start();
            T1.Start();
            T2.Start();
            s1.Stop();

            T1.Join();
            T2.Join();

            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s1.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
