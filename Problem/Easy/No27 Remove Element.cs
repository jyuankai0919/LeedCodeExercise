using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No27_Remove_Element
    {
        public class Solution
        {
            // 爛題目 不需要太過斟酌在這題的詳解
            public int RemoveElement(int[] nums, int val)
            {
                int k = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != val)
                    {
                        nums[k] = nums[i];
                        k++;
                    }
                }
                return k;
            }
        }


        public void Test()
        {
            Console.WriteLine(new Solution().RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
        }
    }
}

