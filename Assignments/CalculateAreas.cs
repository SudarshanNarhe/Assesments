using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.write a code to show the overloading of calculate method.which is calculate the area of rectangle, triangle, area of circle, and area of square.
use the menu driven concept here.*/

namespace Assesments
{
    public class CalculateAreas
    {   
        private double area;
        public double CalculateArea(double length, double width)
        {
                area = length * width;
                 return area;
        }

        public double CalculateArea(double side)
        {
            area = side * side;
            return area;
        }

        public double CalculateArea(double breadth, int height)
        {
            area = 0.5 * (breadth * height);
            return area;
        }

        public double CalculateArea(int radius)
        {
            area = 3.14 * radius * radius;
            return area;
        }
    }
}
