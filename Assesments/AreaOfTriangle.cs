using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//write a code to calculate area of triangle

namespace Assesments
{
    internal class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base of triagle : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a height of trianle : ");
            double h = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * (b * h);
            Console.WriteLine("Area of trianlge is : " + area);
        }
    }
}
