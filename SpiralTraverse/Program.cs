using System;
using System.Collections.Generic;

namespace SpiralTraverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3, 4}, {12, 13, 14, 5},{11, 16, 15, 6},{10, 9, 8, 7} };
            var output = SpiralTraverse(array);
            Console.WriteLine($"Output is: {String.Join<int>(',', output)} ");
        }

        public static List<int> SpiralTraverse(int[,] array)
        {
            // Write your code here.
            return new List<int>();
        }
    }
}
