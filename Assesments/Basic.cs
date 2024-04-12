using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class Basic
    {
       static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 80;

            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }
        

    }

    public class Substraction
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 80;

            int num3 = num1 - num2;
            Console.WriteLine(num3);

        }


    }

    public class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = num1 * num2;
            Console.WriteLine("Multiplication is : "+num3);

        }


    }



}

