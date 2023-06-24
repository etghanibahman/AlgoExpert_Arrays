using System;

namespace NonConstructibleChange
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] coins = new int[] { 1, 2, 5 };
            int[] coins = new int[] { 5, 7, 1, 1, 2, 3, 22 };
            //int[] coins = new int[] { 1, 1, 1, 1, 1 };

            Console.WriteLine($"Smallest not constructible change: {NonConstructibleChange(coins)}");
        }



        #region My_Solution
        public static int NonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);
            int sum = 0;
            for (int i = 0; i <= coins.Length; i++)
            {
                if (i == coins.Length)
                {
                    return sum + 1;
                }
                if (coins[i] > sum + 1)
                {
                    return sum + 1;
                }
                sum += coins[i];
            }
            return -1;
        }
        #endregion


        ////Without plus one
        //public static int NonConstructibleChange(int[] coins)
        //{
        //    Array.Sort(coins);
        //    int changeAmount = 1;
        //    foreach (int coin in coins)
        //    {
        //        if (coin > changeAmount)
        //        {
        //            return changeAmount;
        //        }
        //        changeAmount += coin;
        //    }
        //    return changeAmount;
        //}

    }
}
