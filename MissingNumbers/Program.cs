using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            var solutionXor = 0;
            for (int i = 0; i <= nums.Length + 2; i++)
            {
                solutionXor ^= i;
                if (i < nums.Length)
                {
                    solutionXor ^= nums[i];
                }
            }
            var solution = new int[] { 0, 0 };
            var setBit = solutionXor & -solutionXor;
            for (int i = 0; i <= nums.Length + 2; i++)
            {
                if ((i & setBit) == 0)
                {
                    solution[0] ^= i;
                }
                else
                {
                    solution[1] ^= i;
                }
                if (i < nums.Length)
                {
                    if ((nums[i] & setBit) == 0)
                    {
                        solution[0] ^= nums[i];
                    }
                    else
                    {
                        solution[1] ^= nums[i];
                    }
                }
            }
            Array.Sort(solution);
            return solution;
        }
        #endregion

        #region Using___Summing____O(N)_Time__O(1)_Space
        //public static int[] MissingNumbers(int[] nums)
        //{
        //    var newNumbersLen = nums.Length + 2;
        //    var newNumberSum = newNumbersLen * (newNumbersLen + 1) / 2;
        //    var existingNumberSum = 0;
        //    foreach (var item in nums)
        //    {
        //        existingNumberSum += item;
        //    }
        //    var missingNumberSum = newNumberSum - existingNumberSum;
        //    var avgMissingNumberSum = missingNumberSum / 2;
        //    var sumOfNewLeftHalf = avgMissingNumberSum * (avgMissingNumberSum + 1) / 2;
        //    var sumOfExistingLeftSum = 0;
        //    foreach (var number in nums)
        //    {
        //        if (number <= avgMissingNumberSum)
        //        {
        //            sumOfExistingLeftSum += number;
        //        }
        //    }
        //    var number1 = sumOfNewLeftHalf - sumOfExistingLeftSum;
        //    var number2 = missingNumberSum - number1;
        //    var result = new int[] { number1, number2 };
        //    Array.Sort(result);
        //    return result;
        //}
        #endregion

        #region Using___BinaryEncoding____O(N)_Time__O(1)_Space
        //public static int[] MissingNumbers(int[] nums)
        //{
        //    var n = nums.Length + 2;
        //    var b = Math.Pow(2, n + 1) - 2;
        //    foreach (var elem in nums)
        //    {
        //        b -= Math.Pow(2, elem);
        //    }
        //    var res1 = (int)Math.Log(b, 2);
        //    var res2 = (int)Math.Log(b - Math.Pow(2, res1), 2);

        //    return new int[] { res2, res1 };
        //}
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
