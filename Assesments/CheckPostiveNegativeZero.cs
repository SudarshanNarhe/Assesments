using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//write code to find out the number is positive, negative or zero using ternary operator
namespace Assesments
{
    internal class CheckPostiveNegativeZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            String result = (number > 0) ? "Postive" : (number < 0) ? "Negative" : "Zero";
            Console.WriteLine(number + " is "+result);


        }
    }
}
