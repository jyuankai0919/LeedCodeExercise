using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No70_Climbing_Stairs
    {
        public class Solution
        {
            public int ClimbStairs(int n)
            {
                int[] dp = new int[n];
                dp[0] = 1;
                dp[1] = 1;

                for (int i = 2; i <= n; i++)
                {
                    dp[i] = dp[i - 1] + dp[i - 2];
                }


                return dp[n];
            }
        }

        public void Test()
        { 
            Console.WriteLine(new Solution().ClimbStairs(5));
        }
    }
}
