using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Print "hello"  if number is divisible by 3 and 6 
//Print "world" if number is divisible by 3 and 6 and 9
//Print "helloworld" if number is divisible by 3 

namespace Assesments
{
    internal class CheckDivisibility
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number %3 == 0 && number % 6 ==0 && number % 9 ==0) {
                Console.WriteLine("world");
            }else if(number % 6 == 0 && number % 3 ==0)
            {
                Console.WriteLine("hello");
            }
            else
            {
                Console.WriteLine("helloworld");
            }
        }
    }
}
