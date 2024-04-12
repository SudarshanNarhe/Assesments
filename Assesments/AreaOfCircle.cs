using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//write a code calculate area of circle

namespace Assesments
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            float pie = 3.1415f;
            Console.WriteLine("Enter a radius of a circle : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = pie * radius * radius;
            Console.WriteLine("Area of a cicle is : " + area);
        }
    }
}
