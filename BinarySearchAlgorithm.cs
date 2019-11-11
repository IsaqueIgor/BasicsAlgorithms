using System;
using System.Collections.Generic;
using System.Text;

namespace basic_Algorithms_for_interviews
{
    public class BinarySearchAlgorithm
    {
        public static bool Search(int[] array, int target)
        {
            bool found = false;
            int low = 0;
            int high = array.Length;
            int middle = 0;

            while (!found)
            {
                middle = (low + high) / 2;
                if (target == array[middle])
                {
                    Console.WriteLine("Found Index: " + middle);
                    return true;
                }
                else if (target < array[middle])
                {
                    high = middle;
                }
                else
                {
                    low = middle;
                }
                if (low >= high - 1)
                {
                    return false;
                }

            }
            return found;
        }
    }
}
