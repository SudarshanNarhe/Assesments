using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//⦁	s=1!+2!+3!.........+n! find s

namespace Assesments
{
    internal class Factorial
    {
        public static int FindFactorial(int num)
        {
            int fact=1;
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
           // Console.WriteLine(fact);
            return fact;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for calculate factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = FindFactorial(num);
            Console.WriteLine($"Factorial of {num} is : {fact}");
        }
    }
}
