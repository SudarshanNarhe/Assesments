using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments.StringAssignments
{
    public class MainMethodForString
    {
        static void Main(string[] args)
        {

            //1.WAP to split string into 2 tokens where string is “HELLO$WORLD”
            /*
                        SplitString str = new SplitString();
                        str.SplitStrings("HELLO$WORLD");
            */

            //2.Write a C# program to find first occurrence of a character in a given string.
            
              FindOccurance fo = new FindOccurance();
            /*
            string str1 = "sudarshan";
             char ch = fo.FindfirstOccurance(str1);
              Console.WriteLine(str1);
              Console.WriteLine($"The first occuranance of {str1} is {ch}");

              //3.Write a C# program to count occurrences of a character in given string.
              char ch1 = 's';
              int count =fo.CountOccurance(str1,ch1);
              Console.WriteLine($"The count of occurance of {ch1} is {count}");
  */
            //4.Write a C# program to trim leading white space characters in a string.
             TrimLeading tr = new TrimLeading();
            /*
             string tsr = "    sudarshan";
             string tsr1 = tr.TrimLeadingwhiteSpaces(tsr);
             Console.WriteLine($"Original :{tsr}");
             Console.WriteLine($"After TrimLeading :{tsr1}");
 */

            //5.Write a C# program to count total number of words in a string.
            /* string line = "C# is a Object Oriented Programming Langauage and it supports multithreading";
             TotalWords tw = new TotalWords();
             tw.CountTotalWords(line);
 */
            //6.Write a C# program to remove all occurrences of a character from string.
            /*
            string str = "sudarshan";
            Console.WriteLine($"Original : {str}");
            char ch = 'a';
            string str1=fo.RemoveAllOccurances(str,ch);
            Console.WriteLine($"After removing all occurances of {ch} : {str1}");
       */
            //7.Write a C# program to trim trailing white space characters in a string.
            /*
                        string str7 = "sudarshan      ";
                        Console.WriteLine($"Original :{str7}");
                        string str8 = tr.TrimTrailingwhiteSpaces(str7);
                        Console.WriteLine($"After trim Trailing :{str8}");
            */

            //8.Write a C# program to toggle case of each character of a string.
            /*
                        ToggleCase tc = new ToggleCase();
                        string strr = "sudSJWKSjXna";
                        Console.WriteLine($"Original : {strr}");
                        tc.ChangeToggleCase(strr);
            */

            //9.Write a C# program to count total number of vowels and consonants in a string.
            /* 
             VowelsAndConsonant vc = new VowelsAndConsonant();
              vc.CountVowelsAndConsonant("C# is a Object Oriented Programming langauage");
*/
            //10.Write a C# program to find reverse of a string.
            ReverseString rs = new ReverseString();
            string str = "sudarshan";
            Console.WriteLine($"Original string is  : {str}");
            rs.ReverseGivenString(str);




        }
    }
}
