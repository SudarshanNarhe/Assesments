using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assesments.ArrayAssignments
{
    public class MainMethodForArray
    {
        static void Main(string[] args)
        {

            /*
            //1.WAP to search for a given number in an array and accordingly print the index if exists
            
            int[]arr = { 1, 2, 3 ,5,6,7,8,9,12,3,45,15,78,543};
            PrintArray<int>.Print(arr);
            PrintIndex i = new PrintIndex();
            int num = 45;
           int index= i.Index(num, arr);
            if (index != -1)
            {
                Console.WriteLine($"Index of {num} is : {index}");
            }
            else
            {
                Console.WriteLine("Number is Not found in given Array");
            }

            */

            //2.Write two methods that return the average of an array with following headers.
            /*
                        int[] arr1= {1,2,3,4,5};
                        PrintArray<int>.Print(arr1);
                        int avg = AverageOfArray.Average(arr1);
                        Console.WriteLine(avg);

                        double[] arr2= {5.3,6.2,7.5,8.7,9.8,10.21};
                        PrintArray<double>.Print(arr2);
                        double avg1 = AverageOfArray.Average(arr2);
                        Console.WriteLine(avg1);
            */


            //3.WAP to print all negative elements in an array and also count total number of negative elements in an array.

            /*
                        int[] arr = { 1, 2, -3, 4, -6, -1, -9, 12, 43, -78, 81 };
                        CountNegative ng = new CountNegative();
                        ng.FindNegative(arr);
            */

            //4.WAP to put even and odd elements of array in two separate arrays.
            /*
                        int[] nums = { 2, 3, 2, 4, 5, 6, 7, 65, 24, 54, 65, 89, 32, 13, 47 };

                        FindOddEven fd = new FindOddEven();
                        fd.SeparateArray(nums);
            */

            //5.WAP to find the maximum and minimum value in an array.
            /*
            int[] nums = { 2, 4, 5, 6, 7, 8, 6, 4,0,-3,38 };

            FindMaxAndMin fm = new FindMaxAndMin();
            fm.MaxAndMin(nums);
            */

            //6.WAP to find and count total number of duplicate elements in an array.
            /*
                        int[] nums = { 1, 2, 3, 2, 1, 3, 4, 2, 5, 3, 1 };
                        PrintArray<int>.Print(nums);
                        FindDuplicate dup = new FindDuplicate();
                        dup.FindDuplicateNumbers(nums);
            */


            //7.WAP to print all unique elements in the array.
            /*
                                 int[] nums = { 1, 2, 3, 2, 1, 3, 4, 2, 5, 3, 1 };
                                 PrintArray<int>.Print(nums); 
                                 UniqueElements uq = new UniqueElements();
                                 Console.WriteLine("Unique elements are : ----->> ");
                                 uq.PrintUniqueElements(nums);
            */

            //8.WAP to find the second smallest element in an array.
            /*
                        int[] nums = { 3, 2, 4, 5, 6, 7,3,2,5,6,8,12,12 };
                        PrintArray<int>.Print(nums);
                        SecondSmallest sm = new SecondSmallest();
                       int number= sm.PrintSecondSmallest(nums);
                        Console.WriteLine($"Second Smallest number is : {number}");
            */
            //9.WAP to count frequency of each element in an array.
            int[] arr = { 2, 3, 4, 5, 2, 3, 1, 5, 6, 7, 8, 6, 7, 5 };




        }
    }
}
