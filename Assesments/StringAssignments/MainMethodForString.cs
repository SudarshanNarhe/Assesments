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
            
                        ToggleCase tc = new ToggleCase();
                        string strr = "sudSJWKSjXna";
                        Console.WriteLine($"Original : {strr}");
                        tc.ChangeToggleCase(strr);
            

            //9.Write a C# program to count total number of vowels and consonants in a string.
            /* 
             VowelsAndConsonant vc = new VowelsAndConsonant();
              vc.CountVowelsAndConsonant("C# is a Object Oriented Programming langauage");
*/
            //10.Write a C# program to find reverse of a string.
             ReverseString rs = new ReverseString();

            /* string str = "sudarshan";
             Console.WriteLine($"Original string is  : {str}");
             rs.ReverseGivenString(str);
 */
            //11.Write a C# program to reverse order of words in a given string.
            /*
             ReverseOrder rs = new ReverseOrder();
             rs.ReverseOrderOfWords("C# is object oriented Programming Language");
 */
            //12.Write a C# program to find highest frequency character in a string.
            /*
                        FindFrequency fc = new FindFrequency();
                        fc.FindHighestFrequency("sudarshannnssss");
            */

            //13.Write a C# program to find total number of alphabets, digits or special character in a string.
            /*    
            FindNumbersAndDigits fd = new FindNumbersAndDigits();
            fd.FindTotalNumbersDigitsAndAplabhets("suda123@123");
*/
            //14.Write a C# program to find the duplicate words and their number of occurrences in a string
            /*  FindDuplicateWords fw = new FindDuplicateWords();
              fw.FindDuplicateWordsAndCount("Hello I love dot net and also I love java and python");
  */
            //15.Write a C# program to check whether two strings are anagram or not?
            /* Anagram ng = new Anagram();
             ng.CheckAnagram("silent", "listen");
 */
            //16.Write a C# program to reverse a given string with preserving the position of spaces

            //  rs.ReverseByPreserveSpaces("Hello World");

            //17.WAP to find longest word in the given sentence
            /*
                           LongestWord lw = new LongestWord();
                           string str = "Hello World I am learning dot net";
                           Console.WriteLine(str);
                           lw.FindLongestWord(str);
            */
            //18.How do you swap two string variables without using third or temp variable in C#
            /*
             SwapString ss = new SwapString();
             ss.SwapStringWithoutUsingTemp("Sudarshan", "Suraj");
 */
            //19.Accept email_id from user and check valid or not(should contain @,.)
            /*
                        EmailValidate ev = new EmailValidate();
                        ev.CheckEmailValidation("suda@mail.com");
            */

            //20.Accept sentence replace each vowel by next consecutive character
            /*
                        ReplaceVowel rv = new ReplaceVowel();
                        rv.ReplaceVowelByNextCosn("Asur");
            */

            //21.Create an array of 10 names sort in descending order
            /*    
            SortString ss = new SortString();

            string[] names = { "Sudarshan", "Suraj", "Aadarsh", "Yogesh", "Amol", "Laxman", "Raju", "Pravin", "Nitin", "Balu" };

            Console.WriteLine("Names : ");
            foreach (string name in names)
            {
                Console.Write(name+", ");
            }
            Console.WriteLine();
            ss.SortArrayOfNamesDesc(names);
*/
        }
    }
}
