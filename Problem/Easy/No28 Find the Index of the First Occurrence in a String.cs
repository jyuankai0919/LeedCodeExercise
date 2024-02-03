using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No28_Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        public class Solution
        {
            public int StrStr(string haystack, string needle) {
                if (needle.Length == 0) return 0;
                if (haystack.Length < needle.Length) return -1;
                for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
                {
                    if (haystack[i] == needle[0])
                    {
                        int j = 0;
                        for (; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j]) break;
                        }
                        if (j == needle.Length) return i;
                    }
                }
                return -1;
            }   
        }


        public void Test()
        {
            Console.WriteLine(new Solution().StrStr("sadbutsad","sad"));
        }
    }
}

