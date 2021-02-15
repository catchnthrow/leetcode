using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace leetcode.Problems
{
    class SumOfOddLengthSubArray
    {
        public static void Start()
        {
            try
            {
                Console.Write("Enter the instructions (G/R/L): ");
                var instructions = Console.ReadLine();
                var arr = instructions.Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
                var output = Solve(arr);
                Console.WriteLine(output);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static int Solve(int[] arr)
        {
            var limit = arr.Length % 2 == 0 ? arr.Length - 1 : arr.Length;
            var sum = 0;
            var eta = 1;
            for (var i = 0; i < limit; i += 2)
            {
                for (var k = 0; k <= limit - eta; k++)
                {
                    for (var j = k; j < k + eta; j++)
                    {
                        sum += arr[j];
                    }
                }

                eta += 2;
            }

            return sum;
        }
    }
}
