using System;

namespace leetcode.Problems
{
    public class RobotBoundedInCircle
    {
        public static void Start()
        {
            try
            {
                Console.Write("Enter the instructions (G/R/L): ");
                var instructions = Console.ReadLine();

                var output = Solve(instructions);
                Console.WriteLine(output);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static bool Solve(string instructions)
        {
            var currDirection = 0;  // 0 - north, 1-west, 2-south, 3-east
            var x = 0;
            var y = 0;
            foreach (var t in instructions)
            {
                switch (t)
                {
                    case 'G':
                    {
                        switch (currDirection)
                        {
                                case 0:
                                    y++;
                                    break;
                                case 1:
                                    x--;
                                    break;
                                case 2:
                                    y--;
                                    break;
                                case 3:
                                    x++;
                                    break;
                        }
                        break;
                    }

                    case 'L':
                    {
                        currDirection = currDirection == 3 ? 0 : currDirection + 1;
                        break;
                    }

                    case 'R':
                    {
                        currDirection = currDirection == 0 ? 3 : currDirection - 1;
                        break;
                    }
                }
            }

            return (x == 0 && y == 0) || currDirection != 0;
        }
    }
}
