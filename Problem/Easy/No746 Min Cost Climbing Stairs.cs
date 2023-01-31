using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No746_Min_Cost_Climbing_Stairs
    {
        public class Solution
        {
            public int MinCostClimbingStairs(int[] cost)
            {
                int n = cost.Length;
                int[] dp = new int[n];
                dp[0] = cost[0];
                dp[1] = cost[1];

                for (int i = 2; i < n; i++)
                {
                    dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + cost[i];
                }
                return Math.Min(dp[n - 1], dp[n - 2]);
            }
        }

        public void Test()
        {

            Console.WriteLine(new Solution().MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
        }
    }
}
