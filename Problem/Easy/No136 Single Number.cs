using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No136_Single_Number
    {
        public class Solution
        {
            public int SingleNumber(int[] nums)
            {

                // Initialize the unique number...
                int uniqNum = 0;
                // TRaverse all elements through the loop...
                foreach (int idx in nums)
                {
                    // Concept of XOR...
                    uniqNum ^= idx;
                }
                return uniqNum;       // Return the unique number...
            }

        }
        public void Test()
        {
            int[] vs = { 1, 2, 1, 2, 4 };
            Solution s = new Solution();
            Console.WriteLine(s.SingleNumber(vs));
        }
    }

}
