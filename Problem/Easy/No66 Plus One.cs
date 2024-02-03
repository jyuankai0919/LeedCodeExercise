using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No66_Plus_One
    {
        public class Solution
        {
            public int[] PlusOne(int[] digits)
            {
                // if (digits.Length == 0) return Array.Empty<int>();
                // var index = digits.Length - 1;
                // int x = 0;
                // int[] result = Array.Empty<int>();

                // while (index >= 0)
                // {
                //     if (index == digits.Length - 1)
                //     {
                //         x = digits[index] + 1;
                //     }
                //     else
                //     {
                //         x = digits[index];
                //     }


                //     if (x == 10)
                //     {
                //         digits[index] = 0;

                //         if (index == 0)
                //         {
                //             result = new int[digits.Length + 1];
                //             result[0] = 1;
                //             for (int i = 0; i < digits.Length; i++)
                //             {
                //                 result[i + 1] = digits[i];
                //             }
                //             break;
                //         }
                //         else
                //         {
                //             digits[index - 1] += 1;
                //         }
                //     }
                //     else
                //     {
                //         digits[index] = x;
                //     }
                //     result = digits;
                //     index--;
                // }

                // return result;

                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] < 9)
                    {
                        digits[i]++;
                        return digits;
                    }
                    digits[i] = 0;
                }

                digits = new int[digits.Length + 1];
                digits[0] = 1;
                return digits;
            }
        }


        public void Test()
        {
            Console.WriteLine(new Solution().PlusOne(new int[] { 9, 9, 9, 9, 9, 8, 9, 9, 9, 9, 9, 9, 9 }));
        }
    }
}

