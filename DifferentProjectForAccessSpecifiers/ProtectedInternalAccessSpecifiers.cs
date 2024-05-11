using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentProjectForAccessSpecifiers
{
    public class ProtectedInternalAccessSpecifiers
    {
        static void Main(string[] args)
        {
            AccessSpecifiers.AccessSpecifiersClass obj = new AccessSpecifiers.AccessSpecifiersClass();
            obj.Function5();
            Console.ReadLine();
        }
    }
}
