using System;

namespace ArrayOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 1, 4, 2 };
            
            Console.WriteLine($"Array :{ String.Join<int>(',', array)}");

            Console.WriteLine($"Output is: {String.Join<int>(',', ArrayOfProducts(array))} ");
        }


        #region O(N)
        public int[] ArrayOfProducts(int[] array)
        {
            var result = new int[array.Length];

            int leftRunningProduct = 1;
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = leftRunningProduct;
                leftRunningProduct *= array[i];
            }

            int rightRunningProduct = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result[i] *= rightRunningProduct;
                rightRunningProduct *= array[i];
            }

            return result;
        }
        #endregion

        #region O(N2)
        //public static int[] ArrayOfProducts(int[] array)
        //{
        //    var result = new int[array.Length];

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        int newValue = 1;
        //        for (int j = 0; j < array.Length; j++)
        //        {
        //            if (j == i)
        //            {
        //                continue;
        //            }
        //            newValue *= array[j];
        //        }
        //        result[i] = newValue;
        //    }

        //    return result;
        //}
        #endregion

    }
}
