using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to find the second smallest element in an array.

namespace Assesments.ArrayAssignments
{
    public class SecondSmallest
    {
        public int PrintSecondSmallest(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            PrintArray<int>.Print(arr);
            if (arr[0] == arr[1])
            {
                return arr[2];

            }else
            return arr[1];
        }
    }
}
