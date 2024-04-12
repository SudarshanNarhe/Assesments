using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//⦁	Write a Java program to print all alphabets from a to z. - using  for loop
namespace Assesments
{
    internal class PrintAplabhets
    {
        public static void printsmallAlphabets()
        {
            for(char ch = 'a'; ch <='z'; ch++)
            {   
              
                Console.WriteLine(ch);
            }
        }

        public static void printCapitalAlphabets()
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {

                Console.WriteLine(ch);
            }
        }

        static void Main(string[] args)
        {
            printsmallAlphabets();
            Console.WriteLine();
            printCapitalAlphabets();
        }
    }
}
