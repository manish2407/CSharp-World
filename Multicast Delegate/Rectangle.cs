using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate
{
    public delegate void RectDelegate(double width, double height);
    public class Rectangle
    {
        public void getArea(double width, double height)
        {
            Console.WriteLine("Area is : " + width * height);
        }

        public void getPerimeter(double width, double height) 
        {
            Console.WriteLine("Perimeter is : " + 2 * (width + height));
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            //Delegate Instance
            RectDelegate rd = new RectDelegate(r.getArea);
            RectDelegate rd1 = r.getPerimeter;
            Console.WriteLine("With Delegate");
            rd.Invoke(10.34, 10.34);
            rd1.Invoke(10.34, 10.34);

            // also we can call the delegate instance by this method
            RectDelegate rd2 = r.getArea;
            rd2 += r.getPerimeter;

            rd2.Invoke(13.74, 13.74);
            Console.WriteLine("Without Delegate\n");
            r.getArea(10.34, 10.34);
            r.getPerimeter(10.34, 10.34);
            Console.ReadLine();
        }
    }
}
