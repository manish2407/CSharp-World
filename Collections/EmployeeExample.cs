using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class EmployeeExample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }

    public class TestEmployee
    {
        static void Main(string[] args)
        {
            //Create list of Employye
            List<EmployeeExample> emp = new List<EmployeeExample>();

            //Add employee in the list
            emp.Add(new EmployeeExample { Id = 101, Name = "Manish", Job = "Analyst", Salary = 100000 });
            emp.Add(new EmployeeExample { Id = 103, Name = "Scott", Job = "Associate", Salary = 110000 });
            emp.Add(new EmployeeExample { Id = 102, Name = "John", Job = "AM", Salary = 120000 });
            emp.Add(new EmployeeExample { Id = 104, Name = "Will", Job = "Manager", Salary = 130000 });
            emp.Add(new EmployeeExample { Id = 100, Name = "Kohli", Job = "GOAT", Salary = 140000 });

            //Use foreach to print
            foreach (EmployeeExample example in emp)
            {
                Console.WriteLine(example.Id + " " + example.Name + " " + example.Job + " " + example.Salary);
            }
            Console.ReadLine();
        }

    }
}
