using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to calculate area of an equilateral triangle.
namespace Assesments
{
    internal class AreaOfEquilater
    {
        public static void calAreaOfEquilateralTriangle(int side)
        {
            double area = (Math.Sqrt(3) * side * side) / 4;
            Console.WriteLine("Area of a Equilateral Traingle having side "+side +" is : "+area);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a side of Triangle : ");
            int side = Convert.ToInt32(Console.ReadLine());
            calAreaOfEquilateralTriangle(side);
        }
    }
}
