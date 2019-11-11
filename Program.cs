using System;
using System.Collections.Generic;

namespace basic_Algorithms_for_interviews
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //int[] arraySorted = { 1, 4, 6, 8, 12, 60, 78, 90, 123, 143, 156 };
            //int[] Arrayrandom = { 3, 14, 1, 10, 8, 5 };
            //int[] ArrayGrowing = { 5, 8, 9, 13, 15, 19, 20, 29 };

            //BinarySearchAlgorithm.Search(arraySorted, 60);
            // Arrays.ReverseArray(Arrayrandom);
            //Arrays.DynamicArray(Arrayrandom , 5);

            //char[] wort = { 'h', 'e', 'l', 'l', 'o' };
            //string wortstring = "Brazil";
            //ReverseString reverses = new ReverseString();
            //reverses.ReverseChar(wort);
            //Console.WriteLine(reverses.Reverse(wortstring));

            
            Recursion recursive = new Recursion();
            //Console.WriteLine(recursive.GetFactorial(8));
            List<int> l1 = new List<int>() { 12, 15, 43, 54 };
            List<int> l2 = new List<int>() {  15, 43, 54 };
            recursive.SwapPair(l1);
            recursive.SwapPair(l2);
            //uint a;
            

            //uint b;
            

            //int line = int.Parse(Console.ReadLine());
            //for (var x = 0; x < line; x++)
            //{
            //    uint.TryParse(Console.ReadLine(), out a);
            //    uint.TryParse(Console.ReadLine(), out b);
            //    Console.WriteLine(recursive.GCD(a, b));
            //}

            

            //EasyTwoSum math = new EasyTwoSum();
           // math.Swap(l1);
        }
    }
}
