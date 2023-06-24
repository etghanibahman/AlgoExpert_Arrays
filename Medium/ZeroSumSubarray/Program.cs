using System;

namespace ZeroSumSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test_Case_7
            //Expected output = 3
            var nums = new int[] { -5, -5, 2, 3, -2 };
            #endregion
            Console.WriteLine($"is it a Zero Sum Subarray? {ZeroSumSubarray(nums)}");
        }

        #region Algo_Solution____O(n)_Time__O(n)_Space
        public static bool ZeroSumSubarray(int[] nums)
        {
            int[] sums = new int[nums.Length + 1];
            sums[0] = 0;
            int currentSome = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSome += nums[i];
                if (Array.Exists(sums, e => e == currentSome))
                {
                    return true;
                }
                sums[i+1] = currentSome;
            }
            return false;
        }
        #endregion

        #region My Solution

        #endregion
        //public static bool ZeroSumSubarray(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        var sum = 0;
        //        for (int j = i; j < nums.Length; j++)
        //        {
        //            sum += nums[j];
        //            if (sum == 0)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}
    }
}
