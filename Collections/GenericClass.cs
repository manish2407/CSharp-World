using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class GenericClass
    {
        public bool Comparison(int a, int b)
        {
            if (a == b) return true;
            else return false;
        }
        //using equals method and object type, but it is not type safe as it is comparing object not the datatype
        public bool Comparison1(object a, object b)
        {
            if (a.Equals(b)) return true;
            else return false;
        }
        //to solve this problem, we used generic in the method

        public bool Comparison2<T>(T a, T b)
        {
            if (a.Equals(b)) return true;
            else return false;
        }

        public bool Comparison3<T>(T a, T b)
        {
            if (a.Equals(b)) return true;
            else return false;
        }

        public bool Comparison4<T>(T a, T b)
        {
            if (a.Equals(b)) return true;
            else return false;
        }
        public static void Main(string[] args)
        {
            GenericClass obj = new GenericClass();
            //it will work for the one type only, if we need to use it for other datatype, we need to create the datatype as object
            bool result = obj.Comparison(10, 20);
            bool result1 = obj.Comparison1(26.36f,54.56);
            bool result2 = obj.Comparison2<float>(26.36f, 54.56f);
            bool result3 = obj.Comparison3<string>("Manish","Manish") ;
            bool result4 = obj.Comparison4<string>("Manish","Sharma");



            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            
            Console.ReadLine();
        }
    }
}
