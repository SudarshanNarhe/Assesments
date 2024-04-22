using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    internal class SumBetweenTwoNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for(int i = num1;i<=num2;i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of between " + num1 + " and " + num2 + " is " + sum);
        }
    }
}
