using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    internal class FindSumNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a any Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2 == 0) {
                Console.WriteLine(number +" is a even number");
            }
            else
            {
                Console.WriteLine(number +" is a odd number");
            }
        }
    }
}
