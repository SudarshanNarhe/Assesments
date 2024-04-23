using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//write a code to perform a swapping of two numbers 
namespace Assesments.BasicAssignments
{
    internal class SwapTwoNumbers
    {
        static void Main(string[] args)
        {
            int num1 = 23;
            int num2 = 45;

            Console.WriteLine("Original numbers are : num1 --> " + num1 + " num2 --> " + num2);

            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Swap numbers are : num1 --> " + num1 + " num2 --> " + num2);

        }
    }
}
