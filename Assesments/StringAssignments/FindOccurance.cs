using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assesments.StringAssignments
{
    public class FindOccurance
    {
       
        //2.Write a C# program to find first occurrence of a character in a given string.
        public char FindfirstOccurance(string str)
        {
            char[] ch = str.ToCharArray();
            char cha ='\0';
            int count = 0;
            for(int i = 0; i < ch.Length; i++)
            {
                for(int j=i+1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        cha = ch[i];
                        count++;
                        break;
                    }
                }
                if (count > 0)
                    break;
            }
            return cha;
        }

        //3.Write a C# program to count occurrences of a character in given string.
        public int CountOccurance(string str, char charcter)
        {
            char[] ch = str.ToCharArray();
            int count = 0;

            for(int i=0; i < ch.Length; i++)
            {
                    if (ch[i] == charcter)
                    {
                        count++;
                    }
                
            }
            return count;
        }

        //6.Write a C# program to remove all occurrences of a character from string.
        public string RemoveAllOccurances(string str, char ch)
        {
            char[] chars = str.ToCharArray();
           
            string str1 = "";
            foreach(char c in chars)
            {
                if (c == ch)
                {
                    continue;
                }
                else
                {
                    str1 += c;
                }
            }

            return str1;
        }
    }
}
