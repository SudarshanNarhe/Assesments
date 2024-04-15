using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public abstract class Shape
    {
        public abstract void CalculateArea();

        public void Show()
        {
            Console.WriteLine("In display of abstract class");
        }
    }

    public class Circle : Shape
    {
        private const double pie=3.14;
        private double radius, area;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            area = pie*radius*radius;
        }

        public string Display()
        {
            return $"The area of a circle is : {area}";
        }
    }

    public class Rectangle : Shape
    {
        private double lenght, width, area;

        public Rectangle(double length, double width)
        {
            this.lenght = length;
            this.width = width;
        }
        public override void CalculateArea()
        {
            area = lenght*width;
        }

        public string Display()
        {
            return $"The area of Rectangle is : {area}";
        }
    }

}
