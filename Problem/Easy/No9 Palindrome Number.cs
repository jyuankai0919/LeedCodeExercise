using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No9_Palindrome_Number
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                var str = x.ToString();
                var charArray = str.ToCharArray();
                for (int i = 0; i < charArray.Length - i; i++)
                {
                    var result = ckeckPalindrome(charArray[i], charArray[charArray.Length - i - 1]);
                    if(!result)
                        return false;
                }

                return true;
            }
            public bool ckeckPalindrome(char one, char two)
            {
                if (one == two)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public void Test()
        {
            Console.WriteLine(new Solution().IsPalindrome(-123321));
        }
    }
}

