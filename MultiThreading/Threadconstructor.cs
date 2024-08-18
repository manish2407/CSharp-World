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
        public static void Main(string[] args) {
            Test1();
            //Thread t = new Thread();
            Console.ReadLine();
        }
    }
}
