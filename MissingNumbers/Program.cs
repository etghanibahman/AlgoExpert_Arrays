using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MissingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 3 };
            Console.WriteLine($"the nums are : {String.Join<int>(',', nums)}");
            Console.WriteLine($"the missed nums are : {String.Join<int>(',', MissingNumbers(nums))}");
        }

        #region Using___XOR____O(N)_Time__O(1)_Space
        public static int[] MissingNumbers(int[] nums)
        {
            var n = nums.Length + 2;
            var b = Math.Pow(2, n + 1) - 2;
            foreach (var elem in nums)
            {
                b -= Math.Pow(2, elem);
            }
            var res1 = (int)Math.Log(b, 2);
            var res2 = (int)Math.Log(b - Math.Pow(2, res1), 2);

            return new int[] { res2, res1 };
        }
        #endregion

        #region Using_Dictionary__O(N)_Time__O(n)_Space
        //public static int[] MissingNumbers(int[] nums)
        //{
        //    var numsDic = nums.ToDictionary(a => a, b => true);
        //    List<int> result = new List<int>();
        //    for (int i = 1; i <= nums.Length + 2; i++)
        //    {
        //        if (!numsDic.TryGetValue(i, out bool value))
        //        {
        //            result.Add(i);
        //        }
        //    }
        //    return result.ToArray();
        //}
        #endregion

    }
}
