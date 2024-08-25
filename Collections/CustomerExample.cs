using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class CustomerExample
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
    }

    public class Implementation
    {
        public static void Main(string[] args) {
            List<CustomerExample> ls = new List<CustomerExample>();
            //create an instance for the Values
            CustomerExample c1 = new CustomerExample { CustId = 1000, Name= "Manish", City= "Gurugram", Salary=25000.00 };
            CustomerExample c2 = new CustomerExample { CustId = 1001, Name = "Scott", City = "California", Salary = 25100.00 };
            CustomerExample c3 = new CustomerExample { CustId = 1003, Name = "Smith", City = "LA", Salary = 25120.00 };
            CustomerExample c4 = new CustomerExample { CustId = 1004, Name = "John", City = "texas", Salary = 25150.00 };

            //Add the values to the list
            ls.Add(c1);
            ls.Add(c2);
            ls.Add(c3);
            ls.Add(c4);

        }
    }
}
