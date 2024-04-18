using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Prime Numbers logic
//⦁	Find all prime number between 400 to 300;
namespace Assesments
{
    internal class PrimeNumber
    {
        public static Boolean checkPrimeNumber(int num)
        {
            Boolean isprime=true;
            if (num == 0 || num ==1)
            {
                isprime = false;
            }
            else
            {
                for(int i=2;i<=num/2;i++)
                {
                    if(num%i == 0)
                    {
                        isprime = false;
                        break;
                    }
                   
                }
            }
            /*if (isprime)
            {
                Console.WriteLine("The Number is Prime Number");
            }
            else
            {
                Console.WriteLine("The Number is Not Prime Number");
            }*/

            return isprime;
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter any Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Boolean isprime =checkPrimeNumber(number);
            Console.WriteLine(isprime);
            */

            Console.WriteLine("The prime numbers between 300 to 400 is ----->> ");
            for (int i=300;i<=400;i++)
            {
                bool prime = checkPrimeNumber(i);
                if (prime)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
