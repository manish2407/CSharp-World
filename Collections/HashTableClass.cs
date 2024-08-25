using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class HashTableClass
    {
        public static void Main(string[] args) {
            Hashtable ht = new Hashtable();
            ht.Add("Eno",1010);
            ht.Add("Ename","Scott");
            ht.Add("Job","Manager");
            ht.Add("Salary",25000.00);
            ht.Add("MgrId",1002);
            ht.Add("Email","Scott@gmail.com");
            ht.Add("Dept","Sales");
            ht.Add("Location","Mumbai");
            ht.Add("DeptId",10);

            Console.WriteLine(ht["Email"]);
            //Iterating all the HashTable Keys
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key);
                
            }
            //Iterating all the HashTable Values
            foreach (object Value in ht.Values)
            {
                Console.WriteLine(Value);

            }
            foreach (object Key in ht.Keys)
            {
                Console.WriteLine(Key + " : " + ht[Key]);

            }
            foreach (object Key in ht.Keys)
            {
                Console.WriteLine(" Hash Code Value of "+ Key + " is " + Key.GetHashCode());

            }
            Console.ReadLine();
        }
        
    }
}
