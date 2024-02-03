using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No58_Length_of_Last_Word
    {
        public class Solution
        {
            public int LengthOfLastWord(string s)
            {
                if (s.Length == 0) return 0;
                var array = s.Split(' ');
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i].Length != 0)
                    {
                        return array[i].Length;
                    }
                }
                return 0;
            }
        }


        public void Test()
        {
            Console.WriteLine(new Solution().LengthOfLastWord("   fly me   to   the moon  "));
        }
    }
}

