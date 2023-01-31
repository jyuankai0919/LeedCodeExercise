using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Medium
{
    internal class No62_Unique_Paths
    {
        public class Solution
        {
            public int UniquePaths(int m, int n)
            {
                int[,] ints= new int[m,n];

                for (int i = 0; i < n; i++)
                {
                    ints[0,i] = 1;
                }

                for (int i = 0; i < m; i++)
                {
                    ints[i, 0] = 1;
                }


                for (int i = 1; i < m; i++)
                {
                    for (int j = 1; j < n; j++)
                    {

                        ints[i, j] = ints[i - 1, j] + ints[i, j - 1];

                    }
                }


                return ints[m-1,n-1];
            }
        }


        public void Test()
        {
            Console.WriteLine(new Solution().UniquePaths(3, 7));
        }

    }
}
