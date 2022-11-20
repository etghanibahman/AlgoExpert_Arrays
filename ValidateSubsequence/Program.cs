using System;
using System.Collections.Generic;

namespace ValidateSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<int>() { 1, 2, 3, 4 };
            var sequence = new List<int>() { 1, 2, 4 };

            Console.WriteLine($"Array :{ String.Join<int>(',', array)} , Sequence : {String.Join<int>(',', sequence)}");
            
            Console.WriteLine($"Is sequence valid? {IsValidSubsequence(array,sequence)} ");
        }

        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int indexOfArray = 0;
            int indexOfSeq = 0;
            while (array.Count > indexOfArray && sequence.Count > indexOfSeq)
            {
                if (array[indexOfArray] == sequence[indexOfSeq])
                {
                    indexOfSeq += 1;
                }
                indexOfArray += 1;
            }

            return indexOfSeq == sequence.Count ;
        }
    }
}
