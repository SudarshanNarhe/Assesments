using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to print all unique elements in the array.

namespace Assesments.ArrayAssignments
{
    public class UniqueElements
    {
        public void PrintUniqueElements(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            { 
                bool isUnique = true;

                for (int j = 0 ;  j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if( isUnique )
                {
                    Console.Write(arr[i]+", ");
                }
            }
        }
    }
}
