using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Hard
{
    internal class No85_Maximal_Rectangle
    {
        public class Solution
        {
            //2023/02/02 尚未理解
            public int MaximalRectangle(char[][] matrix)
            {
                if (matrix.Length == 0) return 0;
                int rows = matrix.Length, cols = matrix[0].Length;
                int[] heights = new int[cols + 1];
                int maxArea = 0;
                for (int row = 0; row < rows; row++)
                {
                    Stack<int> stack = new Stack<int>();
                    for (int i = 0; i <= cols; i++)
                    {
                        if (i < cols)
                        {
                            if (matrix[row][i] == '1')
                            {
                                heights[i]++;
                            }
                            else
                            {
                                heights[i] = 0;
                            }
                        }
                        while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                        {
                            int height = heights[stack.Pop()];
                            int width = stack.Count > 0 ? i - stack.Peek() - 1 : i;
                            maxArea = Math.Max(maxArea, height * width);
                        }
                        stack.Push(i);
                    }
                }
                return maxArea;
            }
        }

        public void Test()
        {
            char[][] arr = new char[4][];
            arr[0] = new char[] { '1', '0', '1', '0', '0' };
            arr[1] = new char[] { '1', '0', '1', '1', '1' };
            arr[2] = new char[] { '1', '1', '1', '1', '1' };
            arr[3] = new char[] { '1', '0', '0', '1', '0' };
            Console.WriteLine(new Solution().MaximalRectangle(arr));
        }
    }
}
