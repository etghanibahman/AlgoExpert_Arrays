using System;
using System.Collections.Generic;

namespace MergeOverlappingIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is a jagged array
            #region Test_Case_1
            //int[][] intervals =  {
            //                           new int[] { 1, 2 },
            //                           new int[] { 3, 5 },
            //                           new int[] { 4, 7 },
            //                           new int[] { 6, 8 },
            //                           new int[] { 9, 10}
            //                        };
            #endregion

            #region Test_Case_5
            //int[][] intervals =  {
            //                           new int[] { 100, 105 },
            //                           new int[] { 1, 104}
            //                        };
            #endregion

            #region Test_Case_11
            int[][] intervals =  {
                                       new int[] { 1, 22 },
                                       new int[] { -20, 30}
                                    };
            #endregion

            var overlappedIntervals = MergeOverlappingIntervals(intervals);
            foreach (var item in overlappedIntervals)
            {
                Console.WriteLine($"{String.Join<int>(',', item)}");
            }

        }

        #region Algo_Solution_____Time_O(nlogn)__Space_O(n)
        public static int[][] MergeOverlappingIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0])); // => important note
            List<int[]> result = new List<int[]>();
            int[] prevInterval = intervals[0];
            result.Add(prevInterval);

            for (int i = 0; i < intervals.Length ; i++)
            {
                int[] currInterval = intervals[i];
                if (prevInterval[1] >= currInterval[0])
                {
                    prevInterval[1] = Math.Max(currInterval[1], prevInterval[1]);
                }
                else
                {
                    prevInterval = currInterval;
                    result.Add(prevInterval);
                }
            }

            return result.ToArray();
        }
        #endregion


        #region My_Solution_______Time_O(nlogn)__Space_O(n)
        //public static int[][] MergeOverlappingIntervals(int[][] intervals)
        //{
        //    Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0])); // => important note
        //    Stack<int[]> mergedIntervals = new Stack<int[]>();
        //    foreach (var item in intervals)
        //    {
        //        if (mergedIntervals.Count < 1)
        //        {
        //            mergedIntervals.Push(item);
        //            continue;
        //        }
        //        var lastItem = mergedIntervals.Peek();
        //        if (lastItem[1] >= item[0])
        //        {
        //            var itemToBeReplaced = mergedIntervals.Pop();
        //            //itemToBeReplaced[0] = Math.Min(item[0], itemToBeReplaced[0]);
        //            itemToBeReplaced[1] = Math.Max(item[1], itemToBeReplaced[1]);
        //            mergedIntervals.Push(itemToBeReplaced);
        //        }
        //        else
        //        {
        //            mergedIntervals.Push(item);
        //        }
        //    }
        //    int[][] overlappedIntervals = new int[mergedIntervals.Count][];
        //    for (int i = 0; i < overlappedIntervals.Length; i++)
        //    {
        //        overlappedIntervals[i] = mergedIntervals.Pop();
        //    }

        //    return overlappedIntervals;
        //}
        #endregion

    }
}
