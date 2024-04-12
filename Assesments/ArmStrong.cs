using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// find out the number is armstrong number or not
namespace Assesments
{
    internal class ArmStrong
    {
        public static int getDigitCount(int number)
        {
            int count = 0;
            while(number > 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        public static int calculatePower(int bas, int expo)
        {
            int power = 1;

            for(int i=1;i<=bas; i++)
            {
                power = power * expo;
            }
            return power;
        }

        public static void checkArmStrong(int number)
        {   
            int original = number;
            int bas = getDigitCount(number);
            Console.WriteLine("Count is : " + bas);
            int sum = 0;

            while(number > 0)
            {
                int rem = number % 10;
                int power = calculatePower(bas, rem);
                Console.WriteLine("Power is : "+ power);
                sum = sum + power;
                number /= 10;
            }
            Console.WriteLine("Sum is : "+sum);
            if (original == sum)
            {
                Console.WriteLine(original+ " is ArmStrong Number");
            }
            else
            {
                Console.WriteLine(original + " is NOT ArmStrong Number");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check it is ArmStrong or NOT --->>");
            int number = Convert.ToInt32(Console.ReadLine());
            checkArmStrong(number);
        }


    }
}
