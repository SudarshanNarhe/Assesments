using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    internal class Palindrome
    {
        public static void checkPalindrome(int num)
        {
            int original = num;
            int rev = 0;
            int res;
            while (num > 0)
            {
                res = num % 10;
                rev = rev*10 + res;
                num /= 10;
            }
            Console.WriteLine(rev +" reverse Number");
            if (rev == original)
            {
                Console.WriteLine(original + " is a Palindrome Number");
            }
            else
            {
                Console.WriteLine(original + " is NOT Palindrome Number");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number to check Palindrome --->>");
            int number = Convert.ToInt32(Console.ReadLine());
            checkPalindrome (number);
        }
    }
}
