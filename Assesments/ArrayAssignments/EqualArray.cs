using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a  program to test the equality of two arrays.
//Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and arr2[] = [52, 22, 62, 12, 42, 32]
//Here both arrays are equal.

namespace Assesments.ArrayAssignments
{
    public class EqualArray
    {
        public void CheckEqualArray(int[] num1, int[] num2)
        {
            int[] arr1 = SortArray(num1);
            int[] arr2 = SortArray(num2);

            bool equal = true;

            if (arr1.Length != arr2.Length)
            {
                equal = false;
            }

            for(int i=0; i<arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    equal = false;
                }
            }

            if (equal)
            {
                Console.WriteLine("Both are equal array");
            }
            else
            {
                Console.WriteLine("Both are not equal array");
            }

        }

        public int[] SortArray(int[] arr)
        {

           
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] > arr[j])
                    {

                       int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }


    }
}
