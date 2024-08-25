using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {



        static void Main(string[] args)
        {
            int[] arr = { 12, 49, 37, 89, 93, 56, 3, 45, 43, 89, 23, 67, 56, 23, 45, 67, 78 };

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40) count++;
            }
            int[]brr = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                {
                    brr[index] =arr[i];
                    index++;
                }
            }
            Array.Sort(brr);
            Array.Reverse(brr);

            foreach (int i in brr) { 
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
