using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ArrayLists
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(100);
            arrayList.Add(200);
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(300);
            arrayList.Add(400);
            Console.WriteLine(arrayList.Capacity);
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
                
            }
            Console.WriteLine();
            arrayList.Insert(3, 350);
            arrayList.Insert(4, 375);
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            arrayList.Remove(300);
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

        }
    }
}
