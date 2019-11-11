using System;
using System.Collections.Generic;
using System.Text;

namespace basic_Algorithms_for_interviews
{
    public class Arrays
    {
        public static void ReverseArray(int[] array)
        {
            Console.WriteLine(" Reverse Array: ");

            for (var i = array.Length; i > 0; i--)
            {
                Console.WriteLine(" " + array[i - 1]);
            }
        }

        public static void DynamicArray(int[] array, int rotations)
        {
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array));
            var temp = array[0];
            for (var i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", array));
        }
    }
}
