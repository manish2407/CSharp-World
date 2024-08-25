using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class DictionaryClass
    {
        public static void Main(string[] args)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Eno", 1010);
            dict.Add("Ename", "Scott");
            dict.Add("Job", "Manager");
            dict.Add("Salary", 25000.00);
            dict.Add("MgrId", 1002);
            dict.Add("Email", "Scott@gmail.com");
            dict.Add("Dept", "Sales");
            dict.Add("Location", "Mumbai");
            dict.Add("DeptId", 10);

            Console.WriteLine("keys are");
            foreach (string key in dict.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Values are");
            foreach (object value in dict.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Key and Values are");
            foreach (string Key in dict.Keys)
            {
                Console.WriteLine(Key + " : " + dict[Key]);
            }
            Console.ReadLine();
        }
            
    }
}
