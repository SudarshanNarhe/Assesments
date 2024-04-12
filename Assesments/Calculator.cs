using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    internal class Calculator
    {
        public float calculateSum(float num1, float num2)
        {
            return num1 + num2;
        }
        public float calculateSubstraction(float num1, float num2)
        {
            return num1 - num2;
        }
        public float calculateMultiplication(float num1, float num2)
        {
            return num1 * num2;
        }

        public float calculateDivision(float num1, float num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" 1.Addition \n 2.Substraction \n 3.Multiplication \n 4.Division");
            Console.WriteLine("Enter a Option");
            int option = Convert.ToInt16(Console.ReadLine());
           
                Console.WriteLine("Enter a first Number : ");
                float num1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter a second Number : ");
                float num2 = Convert.ToSingle(Console.ReadLine());

                float res;
                Calculator cal = new Calculator();

                switch (option)
                {
                    case 1:
                        res = cal.calculateSum(num1, num2);
                        Console.WriteLine("The Sum is : " + res);
                        break;
                    case 2:
                        res = cal.calculateSubstraction(num1, num2);
                        Console.WriteLine("The Substraction is : " + res);
                        break;
                    case 3:
                        res = cal.calculateMultiplication(num1, num2);
                        Console.WriteLine("The Multiplication is : " + res);
                        break;
                    case 4:
                        res = cal.calculateDivision(num1, num2);
                        Console.WriteLine("The Division is : " + res);
                        break;
                    default:
                        Console.WriteLine("Please choose a proper option between 1 to 4");
                        break;
                }

        }

    }
}
