using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class GenericCollectionClass
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            list.Insert(2, 25);
            list.Insert(4, 35);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            list.Remove(25);
            Console.WriteLine();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            list.RemoveAt(3);
            Console.WriteLine();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
