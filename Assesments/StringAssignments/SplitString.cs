using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to split string into 2 tokens where string is “HELLO$WORLD”

namespace Assesments.StringAssignments
{
    public class SplitString
    {
        public void SplitStrings(string str)
        {
            char[] chars = str.ToCharArray();
            string str1 = "";
            string str2 = "";

            for(int i=0;i<chars.Length; i++)
            {
                if (chars[i] == '$')
                {
                    break;
                }
                else
                {
                    str1 += chars[i];
                }
            }

            for(int i=str1.Length+1;i<chars.Length;i++)
            {
                str2 += chars[i];
            }

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
