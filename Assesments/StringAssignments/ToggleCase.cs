using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to toggle case of each character of a string.

namespace Assesments.StringAssignments
{
    public class ToggleCase
    {
        public void ChangeToggleCase(string str)
        {
            char[] ch=str.ToCharArray();

            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i]>='a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] - 32);
                }
                else if(ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                }
                
            }

            string str1 = new string(ch);
            Console.WriteLine(str1);
        }
    }
}
