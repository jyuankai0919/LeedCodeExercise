using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Medium
{
    internal class No322_Coin_Change
    {
        public class Solution
        {
            public int CoinChange(int[] coins, int amount)
            {
                int temp = 0;
                for (int i = coins.Length; i >= 2; i--)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (coins[j] > coins[j + 1])
                        {
                            temp = coins[j + 1];
                            coins[j + 1] = coins[j];
                            coins[j] = temp;
                        }
                    }
                }

                int[] dp = new int[amount + 1];
                Array.Fill(dp, int.MaxValue);
                dp[0] = 0;
                for (int i = 0; i < coins.Length; i++)
                {
                    for (int j = coins[i]; j < dp.Length; j++)
                    {
                        if (dp[j - coins[i]] != int.MaxValue)
                        {
                            dp[j] = Math.Min(dp[j], 1 + dp[j - coins[i]]);
                        }
                    }
                }
                return dp[dp.Length - 1] == int.MaxValue ? -1 : dp[dp.Length - 1];

            }
        }

        public void Test()
        {
            Console.WriteLine(new Solution().CoinChange(new int[] { 186, 419, 83, 408 }, 6249));
        }
    }
}
