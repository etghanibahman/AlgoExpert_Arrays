using System;
using System.Collections.Generic;

namespace SweetAndSavory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dishes = new int[] { -3,-5,1,7}; 
            int target = 8;
            Console.WriteLine($"Sweet and savory for taget : {target} and dishes : {String.Join(',',dishes)} is :\n{String.Join(',',SweetAndSavory(dishes,target))}");
        }

        public static int[] SweetAndSavory(int[] dishes, int target)
        {
            if (dishes == null || dishes.Length < 1)
                return new int[] { 0, 0 };
            Array.Sort(dishes);
            List<int> negativeVals = new List<int>();
            List<int> positiveVals = new List<int>();

            for (int i = 0; i < dishes.Length; i++)
            {
                if (dishes[i] < 0)
                    negativeVals.Add(dishes[i]);
                else positiveVals.Add(dishes[i]);
            }
            if (negativeVals.Count < 1)
                return new int[] { 0, 0 };
            negativeVals.Reverse();
            int currentSum = 0, currentSavory = 0, currentSweet = 0, positiveCounter = 0, negativeCounter = 0;
            while (negativeCounter < negativeVals.Count && positiveCounter < positiveVals.Count)
            {
                if ((negativeVals[negativeCounter] + positiveVals[positiveCounter]) > target)
                {
                    if (negativeCounter < negativeVals.Count - 1)
                    {
                        negativeCounter++;
                    }
                    else
                    {
                        break;
                    }

                }
                else if ((negativeVals[negativeCounter] + positiveVals[positiveCounter]) < target)
                {

                    if (Math.Abs(target - (negativeVals[negativeCounter] + positiveVals[positiveCounter])) <= Math.Abs(target - currentSum) || (negativeCounter == 0 && positiveCounter == 0))
                    {
                        currentSum = negativeVals[negativeCounter] + positiveVals[positiveCounter];
                        currentSweet = negativeVals[negativeCounter];
                        currentSavory = positiveVals[positiveCounter];
                    }
                    positiveCounter++;
                }
                else
                {
                    currentSweet = negativeVals[negativeCounter];
                    currentSavory = positiveVals[positiveCounter];
                    break;
                }

            }

            return new int[] { currentSweet, currentSavory };
        }
    }
}
