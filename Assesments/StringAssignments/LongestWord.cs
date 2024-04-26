using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to find longest word in the given sentence

namespace Assesments.StringAssignments
{
    public class LongestWord
    {
        public void FindLongestWord(string str)
        {
            string[] strs = str.Split(' ');

            int max = 0;

            for(int i=0; i<strs.Length; i++)
            {
                if (strs[i].Length > max)
                {
                    max = strs[i].Length;
                }
            }

            for(int i=0;i<strs.Length;i++)
            {
                if (strs[i].Length == max) 
                {
                    Console.WriteLine($"Longest String is : '{strs[i]}' and Length is : {max}");
                }
            }

        }
    }
}
