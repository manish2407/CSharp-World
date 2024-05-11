using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class VariablesType
    {
        //int x = 100; //Non-Static/Instance Variable
        const float pi = 3.14f; //Constant Variable
        int x;
        readonly bool flag;
        public VariablesType(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }

        static int y = 200; //Static Variable
        static void Main(string[] args)
        {
            VariablesType obj = new VariablesType(10,true);
            VariablesType obj2 = new VariablesType(20, false);
            Console.WriteLine(obj.x); //you should create the instance of class to initialize and exexuted
            Console.WriteLine(obj2.x);
            Console.WriteLine(obj.flag);
            Console.WriteLine(obj2.flag);

            /*VariablesType obj = new VariablesType();
            VariablesType obj2 = new VariablesType();
            Console.WriteLine(obj.x); //you should create the instance of class to initialize and exexuted
            Console.WriteLine(obj2.x);*/
            Console.WriteLine(y);
            Console.WriteLine(pi);
            Console.ReadLine();
        }
    }
}
