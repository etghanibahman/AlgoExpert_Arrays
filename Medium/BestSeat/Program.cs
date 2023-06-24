using System;
using System.Collections.Generic;
using System.Linq;

namespace BestSeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var input = new int[] { 1, 0, 1, 0, 0, 0, 1 }; // expected = 4; // Default
            #region Test_Case_1
            //var input = new int[] { 1 };
            #endregion

            #region Test_Case_2
            //var input = new int[] { 1, 0, 1, 0, 0, 0, 1 };
            #endregion

            #region Test_Case_4
            //var input = new int[] { 1, 0, 0, 1 };
            #endregion

            #region Test_Case_7
            //Expected output = 3
            var input = new int[] { 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1 };
            #endregion


            var output = BestSeat(input);
            Console.WriteLine($"The input array is: {String.Join<int>(',',input)}"); 
            Console.WriteLine($"The best seat is: {output}");
        }

        #region Algo_Solution
        /// <summary>
        /// O(n) Time, O(1) Space
        /// </summary>
        /// <param name="seats"></param>
        /// <returns></returns>
        public static int BestSeat(int[] seats)
        {
            int bestSeat = -1;
            int maxSpace = 0;
            int left = 0;
            while (left < seats.Length)
            {
                int right = left + 1;
                while (right < seats.Length && seats[right] == 0)
                {
                    right++;
                }
                int availableSpace = right - left - 1;

                if (availableSpace > maxSpace )
                {
                    bestSeat = (right + left ) / 2;
                    maxSpace = availableSpace;
                }
                left = right;
            }
            return bestSeat;
        }
        #endregion

        #region My_Solution
        //public static int BestSeat(int[] seats)
        //{
        //    if (seats == null || seats.Length < 1)
        //    {
        //        return 0;
        //    }

        //    Dictionary<int, int> indexValue = new Dictionary<int, int>();
        //    for (int i = 1; i < seats.Length; i++)
        //    {
        //        if (seats[i] == 0 && seats[i - 1] != 0)
        //        {
        //            indexValue.Add(i, 0);
        //        }
        //    }

        //    if (indexValue.Count < 1)
        //    {
        //        return -1;
        //    }
        //    var keys = indexValue.Keys.ToList();
        //    foreach (var item in keys)
        //    {
        //        var count = 0;
        //        var idx = item;
        //        while (seats[idx] == 0)
        //        {
        //            count++;
        //            idx++;
        //        }
        //        indexValue[item] = count;
        //    }

        //    var bestSeatValue = indexValue.Values.Max();
        //    var bestSeatIndex = (bestSeatValue % 2 == 0) ? indexValue.Where(a => a.Value == bestSeatValue).FirstOrDefault().Key + (bestSeatValue / 2 - 1)
        //        : indexValue.Where(a => a.Value == bestSeatValue).FirstOrDefault().Key + bestSeatValue / 2;

        //    return bestSeatIndex;
        //}
        #endregion

    }
}
