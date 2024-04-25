using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////Write a C# program to count total number of words in a string.

namespace Assesments.StringAssignments
{
    public class TotalWords
    {
        public void CountTotalWords(string str)
        {
            string[] str1 = str.Split(" ");
            int count = 0;

            foreach (string str2 in str1)
            {
                count++;
            }

            Console.WriteLine($"Total Number of words int string is : {count}");
        }
    }
}
