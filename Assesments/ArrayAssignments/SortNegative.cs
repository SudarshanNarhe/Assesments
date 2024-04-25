using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to arrange the elements of an given array of integers where all negative integers
//appear before all the positive integers.

namespace Assesments.ArrayAssignments
{
    public class SortNegative
    {
        public void SortNegativeArray(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
               
                    for (int j = i + 1; j < arr.Length; j++)
                    {

                        if (arr[i] < 0)
                        {
                            continue;
                        }
                        else
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                
            }

            PrintArray<int>.Print(arr);
        }
    }
}
