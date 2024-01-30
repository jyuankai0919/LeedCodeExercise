using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No20_Valid_Parentheses
    {
        public class Solution
        {
            public bool IsValid(string s)
            {
            
                char leftParenthesis = '(';
                char rightParenthesis = ')';
                char leftBrace = '{';
                char rightBrace = '}';
                char leftBracket = '[';
                char rightBracket = ']';

                var charArray = s.ToCharArray();
                if(charArray == null || charArray.Length == 0)
                    return false;

                var stack = new Stack<char>();
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray[i] == leftParenthesis || charArray[i] == leftBrace || charArray[i] == leftBracket)
                    {
                        stack.Push(charArray[i]);
                    }
                    else
                    {
                        if (stack.Count == 0)
                        {
                            return false;
                        }
                        var temp = stack.Pop();
                        if (temp == leftParenthesis && charArray[i] != rightParenthesis)
                        {
                            return false;
                        }
                        if (temp == leftBrace && charArray[i] != rightBrace)
                        {
                            return false;
                        }
                        if (temp == leftBracket && charArray[i] != rightBracket)
                        {
                            return false;
                        }
                    }
                }

                return stack.Count == 0;
            }
        }


        public void Test()
        {
            Console.WriteLine(new Solution().IsValid("()[]{}"));
        }
    }
}

