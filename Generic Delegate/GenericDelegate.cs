using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
{
    /*public delegate int SumDelegate(int x, int y, int z);
    public delegate void SumVoidDelegate(int x, int y, int z);
    public delegate bool CheckLengthDelegate(string s);*/
    //using Func , Action and Predicate

    public class GenericDelegate
    {
        public static int Sum(int x, int  y, int z)
        {
            return x + y + z;
        }
        public static void SumVoid(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length >= 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            /*SumDelegate obj = Sum;
            int result = obj.Invoke(30, 40, 50);
            Console.WriteLine(result);

            SumVoidDelegate obj1 = SumVoid;
            obj1.Invoke(30, 35, 40);

            CheckLengthDelegate obj2 = CheckLength;
            bool status = obj2.Invoke("Manish");
            Console.WriteLine(status);*/
            //using Func delegate 
            Func<int, int, int, int> obj = Sum;
            int result = obj.Invoke(30, 40, 50);
            Console.WriteLine(result);

            Action<int, int, int> obj1 = SumVoid;
            obj1.Invoke(30, 35, 40);

            Predicate<string> obj2 = CheckLength;
            bool status = obj2.Invoke("Manish");
            Console.WriteLine(status);

            Console.ReadLine();
        }
    }
}
