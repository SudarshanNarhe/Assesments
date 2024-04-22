using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    internal class FibanaccoSeries
    {
        public static void printFibanaccoSeries(int number)
        {
           
            int firstNum = 0;
            int preNum = 1;
            //int nextNum = 1;
            Console.Write(firstNum+", "+preNum);

            for(int i=2; i<number; i++)
            {
                int nextNum = firstNum + preNum;
                Console.Write(", "+nextNum);
                firstNum = preNum;
                preNum = nextNum;

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers you have to print : ");
            int number = Convert.ToInt32(Console.ReadLine());
            printFibanaccoSeries(number);
        }
    }
}
