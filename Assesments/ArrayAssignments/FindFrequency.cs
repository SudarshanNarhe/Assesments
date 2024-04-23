using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to count frequency of each element in an array.

namespace Assesments.ArrayAssignments
{
    public class FindFrequency
    {
        public int FindFrequncy(int[] arr, int num)
        {
            int frequency = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    frequency++;
                }
            }

            return frequency;
        }
    }
}
