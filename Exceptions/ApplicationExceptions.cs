using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{

    public class ApplicationExceptions
    {
        public static void Main(string[] args)
        {
            ApplicationException ex = new ApplicationException("divisor should not be an odd number"); 
            Console.WriteLine("Enter the First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 % 2 > 0)
            {
                //throw ex;
                throw new DivideByOddNumException();
            }
            int result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
