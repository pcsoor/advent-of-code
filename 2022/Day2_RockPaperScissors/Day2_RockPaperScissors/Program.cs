using System;
using System.Text;
namespace Day2_RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* SCORES 
             * rock = 1 [A,X]
             * paper =  [B,Y]
             * scissors = 3 [C,Z]
             * 
             * loose = 0
             * draw = 3
             * win = 6 
            */

            var lines = File.ReadLines("input.txt");
            
            Console.WriteLine(PartOne(lines));
            Console.WriteLine(PartTwo(lines));
        }

        public static int PartOne(IEnumerable<string> lines)
        {
            int totalScore = 0;

            foreach (string line in lines)
            {
                char[] steps = line.ToCharArray();

                int a = steps[0] - 'A';
                int b = steps[2] - 'X';

                // prev: a < b not works in case of a=rock b=scissors
                if (a - b == -1 || (a == 2 && b == 0))
                {
                    totalScore += b + 7;
                }
                else if (a - b == 0)
                {
                    totalScore += b + 4;
                }
                else
                {
                    totalScore += b + 1;
                }
            }

            return totalScore;
        }

        public static int PartTwo(IEnumerable<string> lines)
        {
            int totalScore = 0;

            foreach (string line in lines)
            {
                char[] steps = line.ToCharArray();
                int a = steps[0] - 'A';

                switch (steps[2])
                {
                    case 'X':
                        if (a == 0)
                        {
                            totalScore += 3;
                        }
                        else if (a == 1)
                        {
                            totalScore += 1;
                        }
                        else
                        {
                            totalScore += 2;
                        }
                        break;
                    case 'Y':
                        if (a == 0)
                        {
                            totalScore += 4;
                        }
                        else if (a == 1)
                        {
                            totalScore += 5;
                        }
                        else
                        {
                            totalScore += 6;
                        }
                        break;
                    case 'Z':
                        if (a == 0)
                        {
                            totalScore += 8;
                        }
                        else if (a == 1)
                        {
                            totalScore += 9;
                        }
                        else
                        {
                            totalScore += 7;
                        }
                        break;
                }
            }

            return totalScore;
        }
    }
}