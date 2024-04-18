using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//⦁	WAP to accept base and index from user and calculates power

namespace Assesments
{
    public class Power
    {
        public static int CalculatePower(int bas, int index)
        {
            int power = 1;
            for(int i =1;i<=index; i++)
            {
                power = power * bas;
            }
            return power;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a base : ");
            int bas  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a index : ");
            int index = Convert.ToInt32(Console.ReadLine());

            int power = CalculatePower(bas, index);
            Console.WriteLine($"Power is : {power}");
        }
    }
}
