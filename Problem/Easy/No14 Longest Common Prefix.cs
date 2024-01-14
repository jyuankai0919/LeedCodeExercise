using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No14_Longest_Common_Prefix
    {
        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (strs.Count() == 0)
                {
                    return "";
                }
                else if (strs.Count() == 1)
                {
                    return strs[0];
                }
                strs.Count();
                int longetCount = int.MaxValue;
                for (int i = 1; i < strs.Length; i++)
                {
                    var tempCount = 0;
                    var strLen = Math.Min(strs[0].Length, strs[i].Length);
                    for (int j = 0; j < strLen; j++)
                    {
                        if (strs[0][j] == strs[i][j])
                        {
                            tempCount++; ;
                        }
                        else
                        {
                            break;
                        }
                    }
                    longetCount = Math.Min(longetCount, tempCount);
                }
                return strs[0].Substring(0, longetCount);
            }
        }

        public void Test()
        {
            Console.WriteLine(new Solution().LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
            Console.WriteLine(new Solution().LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
            Console.WriteLine(new Solution().LongestCommonPrefix(new string[] { "cir", "car" }));
        }
    }
}

