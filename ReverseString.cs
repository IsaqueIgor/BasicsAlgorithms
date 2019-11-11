using System;
using System.Collections.Generic;
using System.Text;

namespace basic_Algorithms_for_interviews
{
    public class ReverseString
    {
        public string Reverse(string s)
        {
            if (s.Length > 0)
                return s[s.Length - 1] + Reverse(s.Substring(0, s.Length - 1));
            else
                return s;
        }

        public void ReverseChar(char[] wort)
        {
            var left = 0;
            var right = wort.Length - 1;

            while (left < right)
            {
                char tmp = wort[left];
                wort[left++] = wort[right];
                wort[right--] = tmp;
                Console.WriteLine(tmp);
            }
        }
    }
}
