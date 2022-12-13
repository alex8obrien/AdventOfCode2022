using Lib;

namespace Day1
{
    internal static class Program
    {
        private static void Main()
        {
            int max = 0, sum = 0;
            string input = StdInp.Input("Enter the number of calories each ration pack contains\nWhen starting with a new elf leave blank line");
            List<int> calories = new List<int>();

            while (Convert.ToInt32(input) != -1)
            {
                if (input == string.Empty)
                {
                    calories.Add(-1);
                    sum = 0;
                }
                else
                {
                    calories.Add(Convert.ToInt32(input));
                    sum += Convert.ToInt32(input);
                }
            }

            foreach (int i in calories)
            { Console.WriteLine(i); }

        }
    }
}