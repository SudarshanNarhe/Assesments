using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sum of all even and odd numbers between two numbers

namespace Assesments
{
    internal class SumOfAllEvenAndOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int evensum = 0;
            int oddsum = 0;

            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    evensum += i;
                }
                else
                {
                    oddsum += i;
                }
            }
            Console.WriteLine("Sum of even numbers from " + num1 + " and " + num2 + " is " + evensum);

            Console.WriteLine("Sum of odd numbers from " + num1 + " and " + num2 + " is " + oddsum);
        }
    }
}
