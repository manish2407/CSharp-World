using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class ImplementationClass
    {
        static void Main(string[] args)
        {
            Employee instance = new Employee(101, 20000, "John", "Manager","Bayers","California");
            Console.WriteLine("Emp No. is : " + instance[0]);
            Console.WriteLine("Emp Salary is : " + instance[1]);
            Console.WriteLine("Emp Name is : " + instance[2]);
            Console.WriteLine("Emp Job is : " + instance[3]);
            Console.WriteLine("Emp Last name is : " + instance[4]);
            Console.WriteLine("Emp Location is : " + instance[5]);
            instance[3] = "Senior Manager";
            instance[1] = 36000.00;

            Console.WriteLine("After Updation");
            Console.WriteLine("Emp No. is : " + instance[0]);
            Console.WriteLine("Emp Salary is : " + instance[1]);
            Console.WriteLine("Emp Name is : " + instance[2]);
            Console.WriteLine("Emp Job is : " + instance[3]);
            Console.WriteLine("Emp Last name is : " + instance[4]);
            Console.WriteLine("Emp Location is : " + instance[5]);

            Console.ReadLine();
        }
    }
}
