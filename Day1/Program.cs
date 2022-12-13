namespace Day1
{
    internal static class Program
    {
        private static List<int> Part1()
        {
            int sum = 0;
            Console.WriteLine("Day1\n");
            List<int> data = new();
            List<int> calories = new();

            string dataFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "data.txt");

            using (StreamReader reader = new(dataFile))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine() ?? string.Empty;

                    if (line == string.Empty)
                    {
                        data.Add(-1);
                    }
                    else
                    {
                        data.Add(int.Parse(line));
                    }
                }
            
            foreach (int d in data)
            {
                if (d == -1)
                {
                    calories.Add(sum);
                    sum = 0;
                }
                else
                {
                    sum += d;
                }
            }

            Console.WriteLine($"The elf with the highest calorie count has a count of {calories.Max()}");
            return calories;
        }

        private static void Part2(List<int> calories)
        {
            calories.Sort();
            Console.WriteLine($"The total calorie count of the top 3 elf's is {calories[^1] + calories[^2] + calories[^3]}");
        }

        private static void Main()
        {
            Part2(Part1());
        }
    }
}