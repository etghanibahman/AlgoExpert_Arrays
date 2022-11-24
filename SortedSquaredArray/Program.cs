using System;
using System.Linq;
using System.Collections.Generic;

namespace SortedSquaredArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { -4, -3, 1 , 2 , 3 , 5, 6 };
            int[] array = new int[] { 1, 2, 3, 5, 6, 8, 9 };
            Console.WriteLine($"Input Array is: {String.Join<int>(',', array)} ");
            var sortedArray = SortedSquaredArray(array);
            Console.WriteLine($"Sorted Array is: {String.Join<int>(',', sortedArray)} ");
        }

        #region AlgoExpert_Solution
        public static int[] SortedSquaredArray(int[] array)
        {
            var len = array.Length;
            var result = new int[len];
            for (int i = 0, leftOffset = 0, rightOffset = len - 1; i < len; i++)
                result[len - 1 - i] = (array[rightOffset] <= Math.Abs(array[leftOffset])) ? Squared(array[leftOffset++]) 
                    : Squared(array[rightOffset--]);
            return result;
        }
        private static int Squared(int val) => val * val;
        #endregion

        #region My_Solution
        //public static int[] SortedSquaredArray(int[] array)
        //{
        //    int leftIndex = 0;
        //    int rightIndex = array.Length - 1;
        //    int index = array.Length - 1;
        //    int[] sortedSquareArray = new int[array.Length];
        //    while (leftIndex <= rightIndex)
        //    {
        //        if (Math.Abs(array[leftIndex]) > Math.Abs(array[rightIndex]))
        //        {
        //            sortedSquareArray[index] = array[leftIndex] * array[leftIndex];
        //            leftIndex++;
        //        }
        //        else
        //        {
        //            sortedSquareArray[index] = array[rightIndex] * array[rightIndex];
        //            rightIndex--;
        //        }
        //        index--;
        //    }
        //    return sortedSquareArray;
        //}
        #endregion

    }
}
