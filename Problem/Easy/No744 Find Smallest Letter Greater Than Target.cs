using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No744_Find_Smallest_Letter_Greater_Than_Target
    {
        public class Solution
        {
            public char NextGreatestLetter(char[] letters, char target)
            {
                // Input: letters = ["c", "f", "j"], target = "a"
                // Output: "c"
                // Explanation: The smallest character that is lexicographically greater than 'a' in letters is 'c'.

                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] > target)
                    {
                        return letters[i];
                    }
                }
                return letters[0];
            }
        }
        public void Test()
        {

            var examples = new List<Example>();
            examples.Add(new Example { Letters = new char[] { 'c', 'f', 'j' }, Target = 'a' , Expected = 'c'});
            examples.Add(new Example { Letters = new char[] { 'c', 'f', 'j' }, Target = 'c' , Expected = 'f'});
            examples.Add(new Example { Letters = new char[] { 'x','x','y','y' }, Target = 'z' , Expected = 'x'});

            foreach (var example in examples)
            {
                var letters = example.Letters;
                var target = example.Target;
                var expected = example.Expected;

                // Act
                var solution = new Solution();
                var result = solution.NextGreatestLetter(letters, target);

                // Assert
                if (result == expected)
                {
                    Console.WriteLine("Test Passed");
                }
                else
                {
                    Console.WriteLine("Test Failed");
                }
            }

        }

        public class Example
        {
            public char[]? Letters { get; set; }
            public char Target { get; set; }
            public char Expected { get; set; }
        }

    }
}
