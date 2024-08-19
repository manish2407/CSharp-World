using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class Threadconstructor
    {
        public static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 1: " + i);
                
            }
            Console.WriteLine("Thread 1 is exiting");
        }

        public static void Test2(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Test 2: " + i);

            }
            Console.WriteLine("Thread 2 is exiting");
        }
        public static void Main(string[] args) {
            //Test1();
            // ThreadStart for the method without any parameter
            //ThreadStart obj = new ThreadStart(Test1);
            //ThreadStart obj = Test1;
            //ThreadStart obj = delegate { Test1(); };
            //ThreadStart obj = () => Test1 ();

            // ParameterisedThreadStart for the method with parameter
            
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test2);
            Thread t = new Thread(obj);
            //It is not the typesafe as it is taking object as a parameter
            t.Start(100);
            Console.ReadLine();
        }
    }
}
