using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. Write a Java program to input any alphabet and check whether it is vowel or consonant 
namespace Assesments
{
    internal class CheckVowelsOrConsonent
    {
        public static void checkVowelOrConso(char ch)
        {
            if(ch =='a'||ch=='e' || ch=='i' || ch=='o' || ch == 'u')
            {
                Console.WriteLine(ch + " is a Vowel");
            }
            else
            {
                Console.WriteLine(ch + " is a Consonant");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character to check Vowel or Consonant --->>");
            char ch = Convert.ToChar(Console.ReadLine());
            
            checkVowelOrConso(ch);
        }
    }
}
