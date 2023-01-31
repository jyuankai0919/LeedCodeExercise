using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Medium
{
    internal class No5_Longest_Palindromic_Substring
    {
        public class Solution
        {
            public string LongestPalindrome(string s)
            {

                char[] chars = s.ToCharArray();
                int sNum = chars.Length;

                bool[ , ] dp  = new bool[ sNum, 2 ];
                int maxLen = 0;
                int ans = 0;
                int currCol = 0;

                for (int len = 0; len < sNum; len++)
                {
                    for (int start = 0; start + len  < sNum; start++)
                    {
                        int end = start + len;

                        if (len == 0)
                        {
                            dp[start, currCol] = true;
                        }
                        else if (len == 1)
                        {
                            dp[start, currCol] = chars[start] == chars[end];
                        }
                        else
                        {
                            dp[start, currCol] = chars[start] == chars[end] && dp[start + 1, currCol];
                        }

                        if (dp[start, currCol] &&  len + 1 > maxLen)
                        {
                            maxLen = len + 1;
                            ans = start;
                        }

                    }
                    currCol = 1 - currCol;
                }
                
                return maxLen == 0 ? "" : s.Substring(ans , maxLen);
            }
        }


        public void Test()
        {
            Console.WriteLine(new Solution().LongestPalindrome("asdASDSA"));
        }

    }
}
