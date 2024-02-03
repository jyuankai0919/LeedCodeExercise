using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeExercise.Problem.Easy
{
    internal class No66_Plus_One
    {
        public class Solution
        {
            public int[] PlusOne(int[] digits)
            {
                if(digits.Length == 0) return Array.Empty<int>();
                var index = digits.Length -1 ;
                int x = 0; 
                int[] result = Array.Empty<int>();
                do
                {
                    if(digits[index] == 9 && index == 0)
                    {
                        result = new int[digits.Length + 1];
                        
                    }


                    x = digits[index];
                    if ( x == 10)
                    {


                    }
                } while (true);
            }
        }


        public void Test()
        {
            Console.WriteLine(new Solution().PlusOne(new int[] { 1, 2, 3 }));
        }
    }
}

