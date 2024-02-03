using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No35_Search_Insert_Position
    {
        public class Solution
        {
            public int SearchInsert(int[] nums, int target) {
                if (nums.Length == 0) return 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target || nums[i] > target)
                    {
                        return i;
                    }
                }
                return nums.Length;
            } 
        }


        public void Test()
        {
            Console.WriteLine(new Solution().SearchInsert(new int[]{1,3,5,6},2));
        }
    }
}

