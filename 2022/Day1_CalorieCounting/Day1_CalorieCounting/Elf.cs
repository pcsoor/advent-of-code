using System;
using System.Reflection;

namespace Day1_CalorieCounting
{
	public class Elf
	{
		public List<Calorie> Package { get; set; }
        public List<Elf> ListOfElves { get; set; }
        public int TotalCalorie
        {
            get
            {
                return Package.Sum(x => x.CalorieValue);
            }
        }

        public Elf()
		{
		}

		public void CreateElves(IEnumerable<string> input)
		{
            List<Calorie> calorieValues = new List<Calorie>();
            ListOfElves = new List<Elf>();

            foreach (var value in input)
            {
                if (value == "")
                {
                    Elf elf = new Elf();
                    elf.Package = calorieValues;

                    ListOfElves.Add(elf);

                    calorieValues = new List<Calorie>();
                }
                else
                {
                    Calorie calorie = new Calorie();
                    calorie.CalorieValue = int.Parse(value);

                    calorieValues.Add(calorie);
                }
            }
        }

        public Elf BestElf()
        {
            Elf best = ListOfElves.MaxBy(x => x.TotalCalorie);

            return best;
        }

        public int TotalTopThree()
        {
            var topThreeElf = ListOfElves.OrderByDescending(x => x.TotalCalorie).Take(3);

            return topThreeElf.Sum(x => x.TotalCalorie);
        }
	}
}

