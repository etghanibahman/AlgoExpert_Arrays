using System;
using System.Collections.Generic;

namespace ThreeNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            int targetSum = 0;

            Console.WriteLine($"Array :{ String.Join<int>(',', array)} , TargetSum : {targetSum}");

            var output = ThreeNumberSum(array, targetSum);
            foreach (var item in output)
            {
                Console.WriteLine($"Output is: {String.Join<int>(',', item)} ");
            }

        }


        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);
            var result = new List<int[]>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > targetSum)
                    break;
                int l = i + 1;
                int r = array.Length - 1;
                while (r > l)
                {
                    int sum = array[i] + array[l] + array[r];
                    if (sum < targetSum)
                        l++;
                    else if (sum > targetSum)
                        r--;
                    else
                    {
                        result.Add(new int[] { array[i], array[l], array[r] });
                        r--;
                        l++;
                    }
                        
                }
            }
            return result;
        }

        #region Three for loops
        //public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        //{
        //    Array.Sort(array);
        //    var result = new List<int[]>();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            for (int k = j + 1; k < array.Length; k++)
        //            {
        //                if (array[i] + array[j] + array[k] == targetSum)
        //                {
        //                    result.Add(new int[] { array[i], array[j], array[k] });
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}
        #endregion


    }
}
