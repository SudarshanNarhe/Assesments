using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to count total number of vowels and consonants in a string.

namespace Assesments.StringAssignments
{
    public class VowelsAndConsonant
    {
        public void CountVowelsAndConsonant(string str)
        {   
            str = str.ToLower();

            char[] arr = str.ToCharArray();
            int vcount = 0;
            int ccount = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (char.IsLetter(arr[i]))
                {
                    if (arr[i] == 'a' || arr[i] == 'i' || arr[i] == 'e' || arr[i] == 'o' || arr[i] == 'u')
                    {
                        vcount++;
                    }
                    else
                    {
                        ccount++;
                    }
                }
            }

            Console.WriteLine($"The count of vowels is {vcount} and consonant is {ccount} of the string : {str}");
        }
    }
}
