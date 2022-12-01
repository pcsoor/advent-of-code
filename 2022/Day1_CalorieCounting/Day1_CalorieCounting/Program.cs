using System;
namespace Day1_CalorieCounting
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<string> input = File.ReadLines("input.txt");

            Elf elf = new Elf();

            elf.CreateElves(input);
            Elf bestElf = elf.BestElf();

            // Task #1
            // Find the Elf carrying the most Calories. How many total Calories is that Elf carrying?
            Console.WriteLine(bestElf.TotalCalorie);

            // Task #2
            // Find the top three Elves carrying the most Calories. How many Calories are those Elves carrying in total?
            Console.WriteLine(elf.TotalTopThree());
        }
    }
}
