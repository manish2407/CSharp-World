using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    //Create own custom class Exception by using ApplicationException
    public class DivideByOddNumException : ApplicationException
    {
        public override string Message
        {
            get {
                return "Attempted to divide by Odd number";
            }
        }
    }
}
