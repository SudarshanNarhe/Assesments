using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to find and count total number of duplicate elements in an array.

namespace Assesments.ArrayAssignments
{
    public class FindDuplicate
    {
        public void FindDuplicateNumbers(int[] arr)
        {
            Array.Sort(arr);

            int duplicateCount = 0;
            int prev = arr[0];
            bool foundDuplicate = false;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == prev)
                {
                    if (!foundDuplicate)
                    {
                        Console.WriteLine($"Element: {arr[i]}");
                        foundDuplicate = true;
                        duplicateCount++;
                    }
                    
                }
                else
                {
                    foundDuplicate = false;
                }

                prev = arr[i];
            }

            Console.WriteLine($"Total number of duplicate elements: {duplicateCount}");
        }
    }
}
