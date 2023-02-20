using System;
using System.Collections.Generic;

namespace SpiralTraverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = null;
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
