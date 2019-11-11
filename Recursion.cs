using System;
using System.Collections.Generic;

namespace basic_Algorithms_for_interviews
{
    public class Recursion
    {
        public long GetFactorial(int number)
        {
            if (number == 0) return 1;

            return number * GetFactorial(number - 1);

        }

        public void Pascal(int rows)
        {
            int val = 1, vazio, i, j;
            Console.WriteLine("Triangulo de pascal");

            for (i = 0; i < rows; i++)
            {
                for (vazio = 1; vazio <= rows - i; vazio++)
                    Console.Write("  ");
                    for (j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                            val = 1;
                        else
                            val = val * (i - j + 1) / j;
                        Console.Write(val + "   ");
                    }
                    Console.WriteLine();
            }
        }
        public uint GCD(uint a, uint b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }

        public List<int> SwapPair(List<int> list)
        {

            if (list.Count < 2)
            {
                Console.WriteLine(" Error, list elements less than 2");
                return null;
            }

            var i = 0;

            while(i < (list.Count - 1))
            {
                (list[i], list[i + 1]) = (list[i + 1], list[i]);
                i += 2;
            }

            Console.WriteLine(string.Join("\t", list));

            return list;
           
        }

    }
}
