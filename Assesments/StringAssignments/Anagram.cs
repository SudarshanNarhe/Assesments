using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to check whether two strings are anagram or not?

namespace Assesments.StringAssignments
{
    public class Anagram
    {
        public void CheckAnagram(string str1, string str2)
        {   
            if (str1.Length == str2.Length)
            {
                char[] ch1 = str1.ToCharArray();
                char[] ch2 = str2.ToCharArray();
                int count = 0;

                for(int i=0;i<ch1.Length; i++)
                {

                    for (int j = 0; j < ch2.Length; j++)
                    {
                        if (ch1[i] == ch2[j])
                        {
                            count++;
                            break;
                        }
                    }
  
                }

                if (count==ch1.Length)
                {
                    Console.WriteLine($"{str1} and {str2} are anagrams");
                }
                else
                {
                    Console.WriteLine($"{str1} and {str2} are not anagrams");
                }

            }
            else
            {
                Console.WriteLine($"{str1} and {str2} are not anagrams");
            }
        }
    }
}
