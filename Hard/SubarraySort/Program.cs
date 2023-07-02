using System;

namespace SubarraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 }; // 3,9
            Console.WriteLine($"The input is : {String.Join(',', array)}");
            Console.WriteLine($"The indexes for subarray sort are : {String.Join(',', SubarraySort(array))}");
        }

        public static int[] SubarraySort(int[] array)
        {
            int firstIndex = -1;
            int secondIndex = -1;
            int current = array[0];
            int minValue = int.MaxValue;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < current)
                {
                    minValue = Math.Min(minValue, array[i]);
                    secondIndex = i;
                }
                else
                    current = array[i];

            }
            if (minValue == int.MaxValue)
                return new int[] { firstIndex, secondIndex };

            for (int i = 0; i < array.Length; i++)
            {
                if (minValue < array[i])
                {
                    firstIndex = i;
                    break;
                }
            }

            return new int[] { firstIndex, secondIndex };
        }
    }
}
