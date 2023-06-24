using System;
using System.Linq;

namespace TransposeMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // sample output { { 1, 3, 5 }, { 2, 4, 6 } };
            var output = TransposeMatrix(matrix);
            for (int i = 0; i < output.GetLength(0); i++)
            {
                string rowData = string.Empty;
                for (int j = 0; j < output.GetLength(1); j++)
                {
                    rowData += $"{output[i,j]}, ";
                }
                Console.WriteLine(rowData);
            }
            Console.WriteLine("\nEnd of the code.");
        }

        // O(w * h) Time, O(w * h) Space
        public static int[,] TransposeMatrix(int[,] matrix)
        {
            var inputRows = matrix.GetLength(0);
            var inputColumns = matrix.GetLength(1);

            var output = new int[inputColumns,inputRows];

            for (int i = 0; i < inputColumns; i++)
            {
                for (int j = 0; j < inputRows; j++)
                {
                    output[i, j] = matrix[j,i];
                }
            }
            

            return output;
        }
    }
}
