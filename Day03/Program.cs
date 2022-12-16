using System.Text;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> one = new();
            List<string> two = new();
            ReadData(ref one, ref two);

            
        }

        static void ReadData(ref List<string> one, ref List<string> two)
        {
            int count = 0;

            using StreamReader reader = new("Data.txt");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine() ?? string.Empty;
                int length = line.Length;

                StringBuilder sb = new();

                for (int i = length; i < length / 2; i++)
                {
                    sb.Append(line);
                    line = line.Remove(0);
                }

                count++;
                one[count] = sb.ToString();
                two[count] = line;
            }
        }
    }
}