using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to find the maximum and minimum value in an array.

namespace Assesments.ArrayAssignments
{
    public class FindMaxAndMin
    {
        public void MaxAndMin(int[] arr )
        {
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            PrintArray<int>.Print(arr);

            Console.WriteLine($"Max is : {max}");
            Console.WriteLine($"Min is : {min}");


        }

    }
}
