using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a  program to enter P, T, R and calculate Compound Interest.

namespace Assesments
{
    internal class CoumpundInterest
    {
        public static void calCoumpoundInterest(int p, int t, double r)
        {
            double ci = p * Math.Pow(1 + r / 100, t) - p;
            Console.WriteLine("Compund interest is : "+ci);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Amount : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a rate : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a time : ");
            int t = Convert.ToInt32(Console.ReadLine());

            calCoumpoundInterest(p, t, r);
        }
    }
}
