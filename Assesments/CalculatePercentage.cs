using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    internal class CalculatePercentage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a marks of first subject : ");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a marks of second subject : ");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a marks of third subject : ");
            int sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a marks of fourth subject : ");
            int sub4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a marks of fifth subject : ");
            int sub5 = Convert.ToInt32(Console.ReadLine());

            double percentage = (sub1 + sub2 + sub3 + sub4 + sub5)/5;
            Console.WriteLine("Percentage of 5 subjects is : "+ percentage);
        }
    }
}
