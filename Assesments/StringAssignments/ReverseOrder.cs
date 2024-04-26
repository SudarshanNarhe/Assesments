using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to reverse order of words in a given string.

namespace Assesments.StringAssignments
{
    public class ReverseOrder
    {
        public void ReverseOrderOfWords(string str)
        {
            string[] str1 = str.Split(" ");
            string str2 = "";
            int a = str1.Length - 1;

            for(int i=0;i<str1.Length; i++)
            {
                str2 = str2 + str1[a]+" ";
                a--;
            }

            Console.WriteLine(str2);

        }

    }
}
