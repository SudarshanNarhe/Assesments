using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an array of 10 names sort in descending order

namespace Assesments.StringAssignments
{
    public class SortString
    {
        public void SortArrayOfNamesDesc(string[] names)
        {
            for(int i = 0; i < names.Length; i++)
            {
                for(int j=i+1;j< names.Length; j++)
                {
                    if (string.Compare(names[i], names[j])<0)
                    {
                        string temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                    }
                }
            }

            Console.WriteLine("Names in descending order:");
            foreach (string name in names)
            {
                Console.Write(name+" ,");
            }
            Console.WriteLine();
        }
    }
}
