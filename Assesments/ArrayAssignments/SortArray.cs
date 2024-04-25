using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP sort array elements in ascending order

namespace Assesments.ArrayAssignments
{
    public class SortArray
    {

        public void SortArrayDesc(int[] array)
        {   

            for (int i = 0; i < array.Length; i++)
            {   

                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            PrintArray<int>.Print(array);
        }

        public void SortArrayAsc(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            PrintArray<int>.Print(array);
        }

    }
}
