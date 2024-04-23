using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments.ArrayAssignments
{
    //WAP to search for a given number in an array and accordingly print the index if exists
    public class PrintIndex
    {
        public int Index(int num, int[] numbers)
        {
            int index=-1;
            for(int i=0;i< numbers.Length;i++)
            {
                if (numbers[i] == num)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
