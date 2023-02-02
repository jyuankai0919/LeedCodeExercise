using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Medium
{
    internal class No221_Maximal_Square
    {
        public class Solution
        {
            public int MaximalSquare(char[][] matrix)
            {
                int m = matrix.Length;
                if (m == 0) return 0;
                int n = matrix[0].Length;
                int[,] dp = new int[m + 1, n + 1];
                int MaxLen = 0;
                for (int i = 1; i <= m; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (matrix[i - 1][j - 1] == '1')
                        {
                            dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                            MaxLen = Math.Max(MaxLen, dp[i, j]);
                        }

                    }
                }
                return MaxLen * MaxLen;
            }
        }

        public void Test()
        {
            char[][] arr = new char[2][];
            arr[0] = new char[] { '0', '1'};
            arr[1] = new char[] { '1', '0'};
            Console.WriteLine(new Solution().MaximalSquare(arr));
        }
    }
}
