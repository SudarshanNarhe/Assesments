using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    internal class MaxOfThreeNumbers
    {
        public static void checkMaximumNumber(int num1, int num2,int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1+" is Greater");
                }
                else
                {
                    Console.WriteLine(num2 + " is Greater");
                }
            }else if(num3 > num1)
            {
                if(num3 > num2)
                {
                    Console.WriteLine(num3 + " is Greater");
                }
                else
                {
                    Console.WriteLine(num2 + " is Greater");
                }
            }
            else
            {
                Console.WriteLine(num2 + " is Greater");
            }
        }

        public static void checkGreatestNumber(int num1, int num2, int num3)
        {
         //   int max = (num1 > num2 && num1 > num3) ? num1 : ((num2 > num3) ? num2 : num3);

          //  Console.WriteLine(max +" is Greater");

            string res = num1 > num2 ? (num1 > num3 ? $"{num1} is greatest" : $"{num3} is greatest") : num2 > num3 ? $"{num2} is greatest" : $"{num3} is greatest";
            Console.WriteLine(res);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            checkMaximumNumber(num1, num2, num3);
            Console.WriteLine();
            checkGreatestNumber(num1, num2, num3);
        }
    }
}
