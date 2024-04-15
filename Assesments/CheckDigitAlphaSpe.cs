using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Java program to input any character and check whether it is alphabet, digit or special character 

namespace Assesments
{
    internal class CheckDigitAlphaSpe
    {
        public static void checkCharacter(char ch)
        {
            int val = ch;
            if((val>=65 && val <=90 )||(val >= 97 && val <= 122) )
            {
                Console.WriteLine(ch+ " is a Alphabhet");
            }
            else if((val >= 48 && val <= 57))
            {
                Console.WriteLine(ch +" is a digit");
            }
            else
            {
                Console.WriteLine(ch + " is a Special Character");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character : ");
            char ch = Convert.ToChar(Console.ReadLine());
            checkCharacter(ch);
        }
    }
}
