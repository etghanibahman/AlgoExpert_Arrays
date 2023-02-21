using System;
using System.Collections.Generic;

namespace SpiralTraverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3, 4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10, 9, 8, 7 } };
            var output = SpiralTraverse(array);
            Console.WriteLine($"Output is: {String.Join<int>(',', output)} ");
        }

        public static List<int> SpiralTraverse(int[,] array)
        {
            if (array.GetLength(1) == 1 && array.GetLength(0) == 1)
                return new List<int> { array[0, 0] };

            var sCol = 0;
            var sRow = 0;
            var eCol = array.GetLength(1) - 1;
            var eRow = array.GetLength(0) - 1;
            var result = new List<int>();

            while (eRow >= sRow && eCol >= sCol)
            {
                // left to right
                for (int i = sCol; i <= eCol; i++)
                {
                    result.Add(array[sRow, i]);
                }
                // top to bottom
                for (int i = sRow + 1; i <= eRow; i++)
                {
                    result.Add(array[i, eCol]);
                }
                // right to left
                for (int i = eCol - 1; i >= sCol && eRow > sRow; i--)
                {
                    result.Add(array[eRow, i]);
                }
                // bottom to top
                for (int i = eRow - 1; i > sRow && eCol > sCol; i--)
                {
                    result.Add(array[i, sCol]);
                }

                eCol--;
                sCol++;
                eRow--;
                sRow++;
            }

            return result;
        }
    }
}
