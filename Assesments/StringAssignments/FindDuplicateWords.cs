using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to find the duplicate words and their number of occurrences in a string

namespace Assesments.StringAssignments
{
    public class FindDuplicateWords
    {
        public void FindDuplicateWordsAndCount(string str)
        {
            string[] str1 = str.Split(" ");

            for(int i=0;i<str1.Length; i++)
            {
                int count = 1;

                for(int  j=i+1;j<str1.Length;j++)
                {
                    if (str1[i] == str1[j])
                    {
                        count++;
                    }
                }

                if(count>1)
                Console.WriteLine($"word : {str1[i]}, Frequncy : {count}");
            }
        }
    }
}
