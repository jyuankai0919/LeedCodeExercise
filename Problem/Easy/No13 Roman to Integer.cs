using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No13_Roman_to_Integer
    {
        public class Solution
        {
            public int RomanToInt(string s)
            {

                char[] chars = s.ToCharArray();
                var result = 0;
                var tempVal = 0;
                for (int i = 0; i < chars.Length - 1; i++)
                {
                    tempVal = Change(chars[i]);

                    if (tempVal < Change(chars[i + 1]))
                    {
                        tempVal *= -1;
                    }

                    result += tempVal;

                }

                return result + Change(chars[chars.Length - 1]);
            }
            public int Change(char c)
            {

                switch (c)
                {
                    case 'I':
                        return 1;
                    case 'V':
                        return 5;
                    case 'X':
                        return 10;
                    case 'L':
                        return 50;
                    case 'C':
                        return 100;
                    case 'D':
                        return 500;
                    case 'M':
                        return 1000;

                };
                return 0;
            }

        }
        public void Test()
        {
            TestRomanToInt("III", 3);
            TestRomanToInt("IV", 4);
            TestRomanToInt("IX", 9);
            TestRomanToInt("LVIII", 58);
            TestRomanToInt("MCMXCIV", 1994);
        }
        public void TestRomanToInt(string romanNumeral, int expected)
        {
            Solution solution = new Solution();
            int result = solution.RomanToInt(romanNumeral);
            Console.WriteLine($"Roman numeral: {romanNumeral}, Expected: {expected}, Result: {result}");
            if (result == expected)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
            Console.WriteLine();
        }
    }
}
