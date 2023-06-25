using System;
using System.Collections.Generic;
using System.IO;

namespace FourNumberSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7,6,4,-1,1,2};
            int targetSum = 16;
            Console.WriteLine($"target sum : {targetSum}, array : {String.Join(',',array)}");
            foreach (var item in FourNumberSum(array, targetSum))
            {
                Console.WriteLine($"Founded quadruplets : {String.Join(',', item )}");
            }
        }
        private class Coordinates
        {
            public int LeftIndex { get; set; }
            public int RightIndex { get; set; }
            public Coordinates(int leftIndex, int rightIndex)
            {
                LeftIndex = leftIndex;
                RightIndex = rightIndex;
            }
        }

        public static List<int[]> FourNumberSum(int[] array, int targetSum)
        {
            // split the quadruplet into two pairs: Left and Right
            // identify the left by its rightmost number, and the right by the leftmost

            var leftPartialSum = new Dictionary<int, List<Coordinates>>();
            var rightPartialSum = new Dictionary<int, List<Coordinates>>();

            for (var rightIndex = 1; rightIndex < array.Length; rightIndex++)
                for (var leftIndex = 0;leftIndex < rightIndex;leftIndex++)
                {
                    var partialSum = array[leftIndex] + array[rightIndex];

                    //remember mapping: left partial sum -> coordinates
                    var coordinates = new Coordinates(leftIndex,rightIndex);
                    if (leftPartialSum.TryGetValue(partialSum, out var list))
                        list.Add(coordinates);
                    else
                        leftPartialSum.Add(partialSum, new List<Coordinates> { coordinates});
                }

            for (var leftIndex = array.Length - 2; leftIndex >= 0; leftIndex--)
                for (var rightIndex = leftIndex + 1 ; rightIndex < array.Length; rightIndex++)
                {
                    var partialSum = array[leftIndex] + array[rightIndex];

                    //remember mapping: right partial sum -> coordinates
                    var coordinates = new Coordinates(leftIndex, rightIndex);
                    if (rightPartialSum.TryGetValue(partialSum, out var list))
                        list.Add(coordinates);
                    else
                        rightPartialSum.Add(partialSum, new List<Coordinates> { coordinates });
                }

            var quadrupleList = new List<int[]>();

            foreach (var kvp in leftPartialSum)
            {
                var partialSum = kvp.Key;
                var list1 = kvp.Value;
                var remainingSum = targetSum - partialSum;
                if (rightPartialSum.TryGetValue(remainingSum,out var list2))
                    foreach (var coordinates1 in list1)
                        foreach (var coordinates2 in list2)
                        {
                            if (coordinates1.RightIndex < coordinates2.LeftIndex)
                                quadrupleList.Add(new int[] { array[coordinates1.LeftIndex], array[coordinates1.RightIndex], array[coordinates2.LeftIndex], array[coordinates2.RightIndex] });
                            else
                                break;
                        }
            }

            return quadrupleList;
        }
    }
}
