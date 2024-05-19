using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.DevelopingSoftware
{
    public abstract class Figure
    {
        public double width, height, radius;
        public const float pi = 3.14f;

        public abstract double GetArea();
    }
    class Rectangle : Figure
    {
        public Rectangle(double width, double height) {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return width * height;
        }
    }
    class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return pi * radius * radius;
        }
    }
    class Triangle : Figure
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return 0.5 * width * height;
        }
    }
    class Cone : Figure
    {
        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double GetArea()
        {
            return pi * radius * (radius + Math.Sqrt(height * height + radius * radius));
        }
    }

    class ImplementationClass
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(30, 20);
            Circle c = new Circle(7);
            Triangle t = new Triangle(20, 10);
            Cone co = new Cone(7, 20);
            Console.WriteLine("Area of Rectangle is :" + r.GetArea());
            Console.WriteLine("Area of Circle is :" + c.GetArea());
            Console.WriteLine("Area of Triangle is :" + t.GetArea());
            Console.WriteLine("Area of Cone is :" + co.GetArea());
            Console.ReadLine();
        }

    }
}
