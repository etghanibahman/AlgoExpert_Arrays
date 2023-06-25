using System;

namespace TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = 10;

            Console.WriteLine($"Array :{ String.Join<int>(',', array)} , TargetSum : {targetSum}");

            var output = TwoNumberSum(array, targetSum);
            Console.WriteLine($"Output is: {String.Join<int>(',', output)} ");
        }

        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);
            int leftPointer = 0;
            int rightPointer = array.Length - 1;

            while (leftPointer < rightPointer)
            {
                int calculatedSum = array[leftPointer] + array[rightPointer];
                if (calculatedSum == targetSum)
                {
                    return new int[2] { array[leftPointer], array[rightPointer] };
                }
                else if (calculatedSum > targetSum)
                {
                    rightPointer -= 1;
                }
                else if (calculatedSum < targetSum)
                {
                    leftPointer += 1;
                }
            }

            return new int[0];
        }

        ////Hashset 
        //public static int[] TwoNumberSum(int[] array, int targetSum)
        //{
        //    HashSet<int> visited = new HashSet<int>();
        //    int size = array.Length;
        //    for (int i = 0; i < size; i++)
        //    {
        //        int diff = targetSum - array[i];
        //        if (visited.Contains(diff))
        //        {
        //            return new int[] { array[i], diff };
        //        }
        //        else
        //        {
        //            visited.Add(array[i]);
        //        }
        //    }
        //    return new int[0];
        //}
    }
}
