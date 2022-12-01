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
            Console.WriteLine(bestElf.TotalCalorie);
            Console.WriteLine(elf.TotalTopThree());
        }
    }
}