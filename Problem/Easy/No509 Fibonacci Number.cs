using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No509_Fibonacci_Number
    {
        public class Solution
        {

            // Solution 1
            //public int Fib(int n)
            //{

            //    if (n <= 1)
            //    {
            //        return n;
            //    }

            //    return Fib(n - 1) + Fib(n - 2);
            //}

            // Solution 2
            public int Fib(int n)
            {
                if (n <= 1) return n;
                int[] ints = new int[n + 1];
                ints[0] = 0;
                ints[1] = 1;

                for (int i = 2; i <= n; i++)
                {
                    ints[i] = ints[i - 1] + ints[i - 2];
                }


                return ints[n];
            }

        }


        public void Test()
        {

            Console.WriteLine(new Solution().Fib(15));
        }

    }
}
