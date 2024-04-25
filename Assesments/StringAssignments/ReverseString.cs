using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to find reverse of a string.

namespace Assesments.StringAssignments
{
    public class ReverseString
    {
        public void ReverseGivenString(string str)
        {
            char[] ch = str.ToCharArray();
            string str1 = "";

            for(int i = 0; i < ch.Length; i++)
            {
                str1=ch[i]+str1;
            }

            Console.WriteLine($"Reverse String is : {str1}");
        }

    }
}
