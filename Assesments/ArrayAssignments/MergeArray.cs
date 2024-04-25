using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.

namespace Assesments.ArrayAssignments
{
    public class MergeArray
    {
        public void MergeTwoArray(int[] arr1, int[] arr2)
        {
           /* int[] first = GetUniqueArray(arr1);
            int[] second = GetUniqueArray(arr2);*/

            int[] raw = new int[arr1.Length + arr2.Length];
            int index = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                raw[index++]= arr1[i];
            }

            for(int i = 0;i < arr2.Length; i++)
            {
                raw[index++] = arr2[i];
            }

            int[] merge = GetUniqueArray(raw);
            PrintArray<int>.Print(merge);

        }

      public int[] GetUniqueArray(int[] arr)
      {
            
            int count = 0;

            for(int i=0; i < arr.Length; i++)
            {    
                bool isUnique = false;

                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = true;
                        break;
                    }
                   
                }
                if (!isUnique)
                {
                    count++;
                }
            }

            int[] unique = new int[count];
            int index = 0;

            for(int i=0; i < arr.Length; i++)
            {
                bool isUnique = false;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = true;
                        break;
                    }

                }
                if (!isUnique)
                {
                    unique[index++] = arr[i];
                }
            }
         //  PrintArray<int>.Print(unique);
            return unique;

        }
    }
}
