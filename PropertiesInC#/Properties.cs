using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInC_
{
    class Properties
    {//by default variables are private, we need to make public to access in other class
         double _radius = 3.14;
        // we can menage the access using the getter and setter properties
        public double getRadius() //getter method used to get the value of variable
        {
            return _radius;
        }

        public void setRadius(double radius)
        {
            this._radius = radius;
        }

        //Property block
        public double RadiusProperty
        {
            get { return _radius; }
            set {  _radius = value; }
        }
    }
    public class TestClass
    {
        static void Main(string[] args)
        {
            Properties p = new Properties();
            /*Console.WriteLine(p.radius); //getting the old value
            double radius1 = p.radius;
            Console.WriteLine(radius1);
            p.radius = 10.34; //setting the new value 
            Console.WriteLine(p.radius);
            Console.WriteLine("After using getter and setter properties");
            double radius2 = p.getRadius();
            Console.WriteLine(radius2);
            p.setRadius(22.7);
            Console.WriteLine("after setting the value " + p.radius);*/
            Console.WriteLine("After using Properties");
            double radius = p.RadiusProperty;
            Console.WriteLine("Radius is " +  radius);
            //p.radius = 100.34;
            Console.WriteLine("Radius after setting the value is " + radius);
            Console.ReadLine();
        }
    }
}
