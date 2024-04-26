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
            /*
                        int[] arr = { 2, 3, 4, 5, 2, 3, 1, 5, 6, 7, 8, 6, 7, 5,34 };
                        PrintArray<int>.Print(arr);
                        FindFrequency fq = new FindFrequency();
                        fq.FindFrequencyFromArray(arr);
            */

            //10. WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
            /*
             int[] arr1 = { 1, 2, 3, 4, 5, 6, 2, 3 };
             int[] arr2 = { 1, 2, 3, 4, 5, 6, 2, 3 };
             Console.WriteLine("Original : ");
             PrintArray<int>.Print(arr1);
             PrintArray<int>.Print(arr2);

             MergeArray mg = new MergeArray();
             Console.WriteLine("Merge Array of unique elements is : ");
             mg.MergeTwoArray(arr1 , arr2);
 */
            //11.WAP sort array elements in ascending order
            /*
                        int[] array = { 13, 22, 5, 2, 6, 74, 54, 31 };
                        Console.WriteLine("Original : ");
                        PrintArray<int>.Print(array);
                        SortArray sr = new SortArray();
                        Console.WriteLine("Ascending order : ");
                        sr.SortArrayAsc(array);
                        Console.WriteLine("Descending order : ");
                        sr.SortArrayDesc(array);
                       */

            //12.WAP to reverse the array itself, don’t print array in reverse – I want current array reverse.
            //Means e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3]
            //without using temporary array.

            /*
                        int[] array = { 4, 3, 5, 6, 8, 9, 12, 65 };
                        Console.WriteLine("Original : ");
                        PrintArray<int>.Print(array);
                        ReverseArray ra = new ReverseArray();
                        ra.Reverse_Array(array);
            */

            //13.Write a  program to test the equality of two arrays.
            //Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and arr2[] = [52, 22, 62, 12, 42, 22]
            //Here both arrays are equal.
            /*
                        int[] arr1 = { 12, 22, 32, 42, 52, 62 };
                        int[] arr2 = { 52, 22, 62, 12, 42, 32 };

                        PrintArray<int>.Print(arr1);
                        PrintArray<int>.Print(arr2);

                        EqualArray eq = new EqualArray();
                        eq.CheckEqualArray(arr1, arr2);
            */

            //14.WAP to replace all negative value with its immediate left elements square.
            //Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9]
            //Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].
            /*
                        int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
                        Console.WriteLine("Original : ");
                        PrintArray<int>.Print(arr);
                        ReplaceNegative nr = new ReplaceNegative();
                        nr.ReplaceNegativeValue(arr);
            */

            //15.WAP to arrange the elements of an given array of integers where all negative integers
            //appear before all the positive integers.

            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            Console.WriteLine("Original : ");
            PrintArray<int>.Print(arr);
            SortNegative sort = new SortNegative();
            sort.SortNegativeArray(arr);
             

        }
    }
}
