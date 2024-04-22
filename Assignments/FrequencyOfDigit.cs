using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//⦁	Write a program to find frequency of each digit in a given integer.

namespace Assesments
{
    internal class FrequencyOfDigit
    {
        public static int CalculateFrequency(int num, int digit)
        {   
            int count = 0;
           
            
            while (num != 0)
            {
               int rem = num%10;
                if(rem == digit)
                {
                    count++;
                }
                num /= 10;
            }
            return count;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                int frequency = CalculateFrequency(num, i);
                if(frequency > 0)
                {
                    Console.WriteLine($"Digit {i}: {frequency} times");
                }
            }
        }
    }
}
