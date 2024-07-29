using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEntityProject
{
    public class CustomerImplementationClass
    {
        public static void Main(string[] args) { 
        Customer obj = new Customer(1, false, "John", 10000.34);
        Console.WriteLine("Customer ID is "+ obj.CustId);
            obj.CustId = 2;
            Console.WriteLine("Updated Customer ID is " + obj.CustId);
            obj.Status = false;
            if(obj.Status == true )
            {
                Console.WriteLine("Your Bank Status is Active");
            }
            else
            {
                Console.WriteLine("Your Bank Status is Inactive");
            }
            Console.WriteLine("Customer name is " + obj.CName);
            obj.CName += "Smith"; 
            Console.WriteLine("Updated Customer name is " + obj.CName);
            Console.ReadLine();
    }

    }
}
