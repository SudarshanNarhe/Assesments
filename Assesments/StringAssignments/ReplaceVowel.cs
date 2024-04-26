using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Accept sentence replace each vowel by next consecutive character

namespace Assesments.StringAssignments
{
    public class ReplaceVowel
    {
        public void ReplaceVowelByNextCosn(string str)
        {
            Console.WriteLine("Original : "+str);
            char[] chars = str.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a' || chars[i] == 'e'|| chars[i] == 'i'|| chars[i] == 'o'|| chars[i] == 'u'|| chars[i] == 'A'|| chars[i] == 'E'|| chars[i] == 'I'|| chars[i] == 'O'|| chars[i] == 'U')
                {
                    chars[i] = (char) (chars[i]+1);
                }
            }

            string str1 = new string(chars);
            Console.WriteLine(str1);
        }
    }
}
