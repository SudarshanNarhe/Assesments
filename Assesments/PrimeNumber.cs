using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assesments
{
    internal class PrimeNumber
    {
        public static void checkPrimeNumber(int num)
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
            if (isprime)
            {
                Console.WriteLine("The Number is Prime Number");
            }
            else
            {
                Console.WriteLine("The Number is Not Prime Number");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            checkPrimeNumber(number);
        }
    }
}
