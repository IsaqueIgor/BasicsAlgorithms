using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace basic_Algorithms_for_interviews
{
    public class EasyTwoSum
    {
        /*Example
        Input = [2 ,7 11 ,15], target = 9
        Return [0] [1]
        because 2 + 7 = 9
        */
        public int[] TwoSum(int[] nums, int target)
        {

            if (nums.Length < 2)
                return null;

            // Map for faster search
            var map = new Dictionary<int, short>();

            for (short i = 0; i < nums.Length; i++)
            {
                var n1 = nums[i];
                var desired = target - n1;

                // Check if we have desired in map
                if (map.ContainsKey(desired))
                {
                    // Only one solution expected and we found it
                    return new int[] { map[desired], i };
                }
                else
                {
                    // Add new value to map
                    map[n1] = i;
                }
            }

            return null;
        }

        public List<int> AddTwoNumbers(List<int> l1, List<int> l2)
        {
            List<int> newList = new List<int>();
            List<string> temp = new List<string>();
            l1.Reverse();
            l2.Reverse();

            return newList;
        }


        public void Swap(List<int> list)
        {
            Console.WriteLine(list[0] + " , " + list[1]);
            (list[0], list[1]) = (list[1], list[0]);
            Console.WriteLine(list[0] + " , " + list[1]);
        }
    }
}
