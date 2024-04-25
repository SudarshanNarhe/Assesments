using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. 
 * Means e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3]
 * without using temporary array.*/

namespace Assesments.ArrayAssignments
{
    public class ReverseArray
    {
        public void Reverse_Array(int[] arr)
        {
            int start = 0;
            int end = arr.Length-1;

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            PrintArray<int>.Print(arr);
        }
    }
}
