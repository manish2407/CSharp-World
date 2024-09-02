using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    public class DataTypes
    {
        static void Main()
        {

            // declaring character
            char a = 'G';

            // Integer data type is generally
            // used for numeric values
            int i = 89;

            short s = 56;

            // this will give error as number
            // is larger than short range
            // short s1 = 87878787878;

            // long uses Integer values which 
            // may signed or unsigned
            long l = 4564;

            // UInt data type is generally
            // used for unsigned integer values
            uint ui = 95;

            ushort us = 76;
            // this will give error as number is
            // larger than short range

            // ulong data type is generally
            // used for unsigned integer values
            ulong ul = 3624573;

            // by default fraction value
            // is double in C#
            double d = 8.358674532;

            // for float use 'f' as suffix
            float f = 3.7330645f;

            // for float use 'm' as suffix
            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);

            sbyte sa = 126;

            // sbyte is 8 bit 
            // singned value
            Console.WriteLine(sa);

            sa++;
            Console.WriteLine(sa);

            // It overflows here because
            // byte can hold values 
            // from -128 to 127
            sa++;
            Console.WriteLine(sa);

            // Looping back within 
            // the range
            sa++;
            Console.WriteLine(sa);

            //Operation on bytes
            byte ba = 0;

            // byte is 8 bit 
            // unsigned value
            Console.WriteLine(ba);

            ba++;
            Console.WriteLine(ba);

            ba = 254;

            // It overflows here because
            // byte can hold values from
            // 0 to 255
            ba++;
            Console.WriteLine(ba);

            // Looping back within the range
            ba++;
            Console.WriteLine(ba);

            //boolean Operation
            bool bb = true;
            if (bb == true)
                Console.WriteLine("Hi Geek");

            string str = "Geeks";

            //append in a
            str += "for";
            str = str + "Geeks";
            Console.WriteLine(a);

            // declare object obj
            object obj;
            obj = 20;
            Console.WriteLine(obj);

            // to show type of object
            // using GetType()
            Console.WriteLine(obj.GetType());

            Console.ReadLine();
        }
    }
}
