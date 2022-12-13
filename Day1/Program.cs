using System.Reflection;

namespace Day1
{
    internal static class Program
    {
        private static void Main()
        {
            int sum = 0;
            Console.WriteLine("Day1\n");
            List<int> data = new();
            List<int> calories = new();
            
            string DATAFILE = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "data.txt");

            using (StreamReader reader = new(DATAFILE))
            {
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
        }
    }
}