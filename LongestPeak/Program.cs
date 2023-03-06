using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestPeak
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };

            #region test case 3
            array = new int[] { 1, 3, 2 };
            #endregion

            #region test case 7
            array = new int[] { 5, 4, 3, 2, 1, 2, 10, 12 };
            #endregion
            Console.WriteLine($"The longest peak is : {LongestPeak(array)}");
        }

        //Time o(N) , Space O(1)
        public static int LongestPeak(int[] array)
        {
            if (array.Length < 3)
            {
                return 0;
            }
            Dictionary<int, int> dicArrayPeaks = new Dictionary<int, int>();
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i-1] && array[i] > array[i+1])
                {
                    dicArrayPeaks.Add(i, 0);
                }
            }
            
            var keys = dicArrayPeaks.Keys.ToList();
            if (keys.Count ==0)
            {
                return 0;
            }
            foreach (var idx in keys)
            {
                int leftIdx = idx - 1;
                int rightIdx = idx + 1;
                int counter = 3;
                bool leftCheck = true;
                bool rightCheck = true;

                while (leftCheck || rightCheck)
                {
                    if (leftIdx - 1 >= 0 && array[leftIdx - 1] < array[leftIdx])
                    {
                        counter++;
                        leftIdx--;
                    }
                    else
                    {
                        leftCheck = false;
                    }
                    if (rightIdx + 1 < array.Length && array[rightIdx + 1] < array[rightIdx])
                    {
                        counter++;
                        rightIdx++;
                    }
                    else
                    {
                        rightCheck = false;
                    }
                }
                dicArrayPeaks[idx] = counter;
            }

            return dicArrayPeaks.Values.Max();
        }

    }
}
