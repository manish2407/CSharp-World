using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class MultiThreading
    {
        public static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 1: " + i);
                if (i == 50)
                {
                    Console.WriteLine("thread 1 going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread 1 woke up");
                }
                
            }
            Console.WriteLine("Thread 1 is exiting");
        }
        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 2: " + i);
            }
            Console.WriteLine("Thread 2 is exiting");
        }
        public static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 3: " + i);
            }
            Console.WriteLine("Thread 3 is exiting");
        }
        static void Main(string[] args)
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start();
            T2.Start();
            T3.Start();
            Console.WriteLine("Main Thread is exiting");
            Console.ReadLine();
        }
    }
}
