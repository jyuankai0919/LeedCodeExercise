using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Interview
{
    internal class stringReverse
    {
        public class Solution
        {
            public string ReverseTets(string S)
            {
                char[] chars = S.ToCharArray();

                Array.Reverse(chars);

                string reverse = new string(chars);

                return reverse;
            }

        }

        public void Test()
        {
            Console.WriteLine(new Solution().ReverseTets("abcde"));
        }
    }
}


