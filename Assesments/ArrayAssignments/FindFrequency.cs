using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to count frequency of each element in an array.

namespace Assesments.ArrayAssignments
{
    public class FindFrequency
    {
        public void FindFrequencyFromArray(int[] num)
        {

            for (int i = 0; i < num.Length; i++)
            {
                int count = 0;

                bool isPrint = false;

                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        isPrint = true;

                    }
                }

                if (isPrint)
                {
                    bool notPrint = true;

                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (num[i] == num[k])
                        {
                            notPrint = false;
                            break;
                        }
                    }
                    if (notPrint)
                    {
                        Console.WriteLine($"{num[i]} repeates ---->> {count} times");
                    }

                }


            }

        }

    }
}
