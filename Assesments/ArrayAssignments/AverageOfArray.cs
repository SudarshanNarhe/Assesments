using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write two methods that return the average of an array with following headers.
public static int average(int[] array)
public static double average(double[] array).
Write main and invoke the 2 methods.*/


namespace Assesments.ArrayAssignments
{
    public class AverageOfArray
    {
        public static int Average(int[] array)
        {
            int sum = 0;
            
            foreach (int item in array)
            {
                sum += item;
            }

            int avg = sum/array.Count();
            return avg;
        }

        public static double Average(double[] array)
        {
            double sum = 0;

            foreach (double item in array)
            {
                sum += item;
            }

            double avg = sum / array.Count();
            return avg;
        }

    }
}
