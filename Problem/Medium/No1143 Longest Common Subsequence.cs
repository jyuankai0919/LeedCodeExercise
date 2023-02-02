﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Medium
{
    internal class No1143_Longest_Common_Subsequence
    {
        public class Solution
        {
            public int LongestCommonSubsequence(string text1, string text2)
            {
                int m = text1.Length;
                int n = text2.Length;
                int[,] dp = new int[m + 1, n + 1];

                for (int i = 1; i <= m; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (text1[i - 1] == text2[j - 1])
                            dp[i, j] = dp[i - 1, j - 1] + 1;
                        else
                            dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }

                return dp[m, n];
            }
        }

        public void Test()
        {
            Console.WriteLine(new Solution().LongestCommonSubsequence("asd", "dasdasdasdasd"));
        }
    }
}
