using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to replace all negative value with its immediate left elements square.
//Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9]
//Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].


namespace Assesments.ArrayAssignments
{
    public class ReplaceNegative
    {
        public void ReplaceNegativeValue(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]< 0)
                {
                    arr[i] = arr[i - 1] * arr[i-1];
                }
            }

            PrintArray<int>.Print(arr);
        } 
    }
}
