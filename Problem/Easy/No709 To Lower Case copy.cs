using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No709_To_Lower_Case
    {
        public class Solution
        {
            public string ToLowerCase(string s)
            {
                var result = new StringBuilder();
                foreach (var c in s)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        result.Append((char)(c + 32));
                    }
                    else
                    {
                        result.Append(c);
                    }
                }
                return result.ToString();

            }

            public string ToLowerCase2(string s)
            {
                var sArray = s.ToCharArray();
                for (var i = 0; i < sArray.Length; i++)
                {
                    var d = Convert.ToDecimal((byte)sArray[i]);
                    if (d >= 65 && d <= 90)
                    {
                        sArray[i] = Convert.ToChar((byte)(d + 32));
                    }
                }

                return new string(sArray);

            }

        }
        public void Test()
        {
            // Arrange
            string input = "HELLO WORLD";
            string expected = "hello world";

            // Act
            string result = new Solution().ToLowerCase(input);

            // Assert
            Console.WriteLine("expected: {0}, result: {1} , testResult: {2}", expected, result, expected == result);
        }
    }
}
