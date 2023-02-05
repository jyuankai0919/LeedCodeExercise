using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Medium
{
    internal class No97_Interleaving_String
    {
        public class Solution
        {

            #region Solution A - 2D array
            //public bool IsInterleave(string s1, string s2, string s3)
            //{
            //    int m = s1.Length;
            //    int n = s2.Length;
            //    if (m + n != s3.Length) return false;

            //    bool[,] dp = new bool[m + 1, n + 1];


            //    for (int i = 0; i <= m; i++)
            //    {
            //        for (int j = 0; j <= n; j++)
            //        {
            //            if (i == 0 && j == 0)
            //            {
            //                dp[i, j] = true;
            //            }
            //            else if (i == 0)
            //            {
            //                dp[i, j] = dp[i, j - 1] && s2[j - 1] == s3[j - 1];
            //            }
            //            else if (j == 0)
            //            {
            //                dp[i, j] = dp[i - 1, j] && s1[i - 1] == s3[i - 1];
            //            }
            //            else
            //            {
            //                dp[i, j] =
            //                    dp[i - 1, j] && s1[i - 1] == s3[i + j - 1]
            //                        || dp[i, j - 1] && s2[j - 1] == s3[i + j - 1];
            //            }
            //        }
            //    }

            //    return dp[m, n];
            //}
            #endregion

            #region Solution B - 1D array
            public bool IsInterleave(string s1, string s2, string s3)
            {
                int m = s1.Length;
                int n = s2.Length;
                if (m + n != s3.Length) return false;

                bool[] dp = new bool[n + 1];


                for (int i = 0; i <= m; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            dp[j] = true;
                        }
                        else if (i == 0)
                        {
                            dp[j] = dp[j - 1] && s2[j - 1] == s3[j - 1];
                        }
                        else if (j == 0)
                        {
                            dp[j] = dp[j] && s1[i - 1] == s3[i - 1];
                        }
                        else
                        {
                            dp[j] =
                                dp[j] && s1[i - 1] == s3[i + j - 1]
                                    || dp[j - 1] && s2[j - 1] == s3[i + j - 1];
                        }
                    }
                }

                return dp[n];
            }
            #endregion
        }
        public void Test()
        {
            Console.WriteLine(new Solution().IsInterleave("ab", "acd", "acabd"));
        }
    }
}
