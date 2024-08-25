using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class LinqClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 12, 49, 37, 89, 93, 56, 3, 45, 43, 89, 23, 67, 56, 23, 45, 67, 78 };
            var brr = from i in arr where i > 40 orderby i descending select i;

            foreach (var b in brr)
            {
                Console.Write(b + " ");
            }
            Console.ReadLine();
        }
    }
}
