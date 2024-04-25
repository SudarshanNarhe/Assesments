using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments.StringAssignments
{

    public class TrimLeading
    {
        public string RemoveAllWhiteSpaces(string str)
        {
            string str1 = "";

            char[] ch = str.ToCharArray();

            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == ' ')
                {
                    continue;
                }
                else
                {
                    str1 += ch[i];
                }
            }

            return str1;
        }

        //4.Write a C# program to trim leading white space characters in a string.
        public string TrimLeadingwhiteSpaces(string str)
        {
            int startindex = 0;

            while(startindex < str.Length && char.IsWhiteSpace(str[startindex] )) 
            {
                startindex++;
            }

            return str.Substring(startindex);
        }

        //Write a C# program to trim trailing white space characters in a string.

        public string TrimTrailingwhiteSpaces(string str)
        {
            int endindex = str.Length-1;

            while (endindex >= 0 && char.IsWhiteSpace(str[endindex]))
            {
                endindex--;
            }

            return str.Substring(0,endindex+1);
        }
    }
}
