using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to find highest frequency character in a string.

namespace Assesments.StringAssignments
{
    public class FindFrequency
    {
        public void FindHighestFrequency(string str)
        {
            char[] cha = str.ToCharArray();
            int max = 0;
            char ch = ' ';

            for(int i=0;i<cha.Length; i++)
            {
                int count = 1;

                for(int j = i + 1; j < cha.Length; j++)
                {
                    if (cha[i]== cha[j])
                    {
                        count++;
                    }
                }
               
                    if (count > max)
                    {
                        max = count;
                        ch = cha[i];
                   }
                
                
            }

            Console.WriteLine($"Highest Frequncy character of string {str} is {ch} and repeats {max} times");
        }
    }
}
