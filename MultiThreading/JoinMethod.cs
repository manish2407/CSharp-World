using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class JoinMethod
    {
        public static void Test1()
        {
            Console.WriteLine("Thread 1 is entering");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test 1: " + i);

            }
            Console.WriteLine("Thread 1 is exiting");

        }
        public static void Test2()
        {
            Console.WriteLine("Thread 2 is entering");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test 2: " + i);

            }
            Console.WriteLine("Thread 2 is exiting");

        }
        public static void Test3()
        {
            Console.WriteLine("Thread 3 is entering");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test 3: " + i);

            }
            Console.WriteLine("Thread 3 is exiting");

        }
        public static void Main(string[] args) {
            Console.WriteLine("Main Thread is Entering");
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start();
            T2.Start();
            T3.Start();
            T1.Join();
            T2.Join();
            T3.Join();
            Console.WriteLine("Main Thread is Exiting");
            Console.ReadLine();
        }
    }
}
