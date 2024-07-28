using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public class EnumerationClass
    {
        public enum Days
        {
            //we can also define like Monday=1, tuesday=7 etc 
            //we can get the name and values using Enum.getValues and Enum.getNames(typeof(Days) using foreach loop
            Monday,
            tuesday,
            wednesday,
            Thursday,
            friday,
        }

        public enum Student
        {
            Manish = 1,
            Gabbu = 11,
            Mannu = 21,
            Bado = 31,
        }
        static void Main(string[] args)
        {
            //Only for first value we can give 0, for others we need to typecast that
            Days d = (Days)3;
            //we can assign it like
            Days d1 = Days.friday;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(d);
            Console.WriteLine(d1);
            foreach (int i in Enum.GetValues(typeof(Student))){
                Console.WriteLine(i);
            }
            foreach (string s in Enum.GetNames(typeof(Student)))
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
