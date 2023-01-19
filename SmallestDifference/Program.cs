using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { -1, 5, 10, 20, 28, 3 };
            int[] arrayTwo = new int[] { 26, 134, 135, 15, 17 };

            Console.WriteLine($"arrayOne is: {String.Join<int>(',', arrayOne)} ");
            Console.WriteLine($"arrayTwo is: {String.Join<int>(',', arrayTwo)} ");

            Console.WriteLine($"SmallestDifference Array is: {String.Join<int>(',', SmallestDifference(arrayOne, arrayTwo))} ");
        }

        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int leftPointer = 0;
            int rightPointer = 0;
            int diff = int.MaxValue;

            int[] result = new int[2];

            while (leftPointer < arrayOne.Length && rightPointer < arrayTwo.Length)
            {
                int curDiff = Math.Abs(arrayOne[leftPointer] - arrayTwo[rightPointer]);
                if (curDiff < diff)
                {
                    diff = curDiff;
                    result = new int[] { arrayOne[leftPointer], arrayTwo[rightPointer] };
                }
                    
                if (arrayOne[leftPointer] < arrayTwo[rightPointer])
                    leftPointer++;
                else
                    rightPointer++;

            }
            return result;
        }

        //public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        //{
        //    List<(int firstEl, int secondEl, int def)> allTuples = new List<(int firstEl, int secondEl, int def)>();

        //    Array.Sort(arrayOne);
        //    Array.Sort(arrayTwo);

        //    for (int i = 0; i < arrayOne.Length; i++)
        //    {
        //        for (int j = 0; j < arrayTwo.Length; j++)
        //        {
        //            int def = Math.Abs(arrayOne[i] - arrayTwo[j]);
        //            if (j-1 >0 && def >= Math.Abs(arrayOne[i] - arrayTwo[j - 1]))
        //                break;
        //            allTuples.Add((arrayOne[i],arrayTwo[j],def));
        //        }
        //    }

        //    int minDiff = allTuples.Min(a => a.def);


        //    return allTuples.Where(a=>a.def == minDiff).Select(a => new int[] { a.firstEl,a.secondEl}).FirstOrDefault();
        //}
    }
}
