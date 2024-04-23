using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to put even and odd elements of array in two separate arrays.

namespace Assesments.ArrayAssignments
{
    public class FindOddEven
    {
        public void SeparateArray(int[] array)
        {
            int[] even;
            int[] odd;
            int evecount = 0;
            int oddcount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0) 
                { 
                    evecount++;
                }
                else if (array[i]%2 != 0)
                {
                    oddcount++;
                }
            }
            even = new int[evecount];
            odd = new int[oddcount];

            evecount = 0;
            oddcount = 0;   

            for(int i = 0;i < array.Length;i++)
            {
                if (array[i]%2 == 0)
                {
                    even[evecount] = array[i];
                    evecount++;
                }
                else if (array[i]%2 != 0)
                {
                    odd[oddcount] = array[i];
                    oddcount++;
                }

            }

            Console.WriteLine("Original ---->> ");
            PrintArray<int>.Print(array);
            Console.WriteLine("Even ---->> ");
            PrintArray<int>.Print(even);
            Console.WriteLine("Odd ---->> ");
            PrintArray<int>.Print(odd);

        }
    }
}
