using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Medium
{
    internal class No96_Unique_Binary_Search_Trees
    {
        public class Solution
        {
            public Dictionary<int, int> dp = new Dictionary<int, int>();
            
            public int NumTrees(int n)
            {
                if (dp.ContainsKey(n))
                {
                    return dp[n];
                }
                if (n == 0)
                {
                    return 1;
                }

                int ans = 0;
                for (int i = 1; i <= n; i++)
                {
                    int left = NumTrees(i - 1);
                    int right = NumTrees(n - i);
                    ans += left * right;

                }
                dp.Add(n, ans);

                return ans;
            }
        }


        public void Test()
        {

            Console.WriteLine(new Solution().NumTrees(5));


        }
    }
}
