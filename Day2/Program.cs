namespace Day02
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors.");
            List<int> choices = new List<int>();
            int score1 = 0, score2 = 0;
            
            string dataFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "data.txt");
            using StreamReader reader = new(dataFile);
            while (!reader.EndOfStream)
            {
                string[] input = (reader.ReadLine() ?? string.Empty).Split(' ');
                string computer = input[0];
                string player = input[1];
                
                switch (player)
                {
                    case "X":
                        score1++;
                        switch (computer)
                        {
                            case "A":
                                score1 += 3;
                                break;
                            case "C":
                                score1 += 6;
                                break;
                        }
                        break;
                    
                    case "Y":
                        score1 += 2;
                        switch (computer)
                        {
                            case "A":
                                score1 += 6;
                                break;
                            case "B":
                                score1 += 3;
                                break;
                        }
                        break;

                    case "Z":
                        score1 += 3;
                        switch (computer)
                        {
                            case "B":
                                score1 += 6;
                                break;
                            case "C":
                                score1 += 3;
                                break;
                        }
                        break;
                }
                
                switch (computer)
                {
                    case "A":
                        switch (player)
                        {
                            case "X":
                                score2 += 3;
                                break;
                            
                            case "Y":
                                score2 += 4;
                                break;
                            
                            case "Z":
                                score2 += 8;
                                break;
                        }
                        break;
                        
                    case "B":
                        switch (player)
                        {
                            case "X":
                                score2 += 1;
                                break;
                            
                            case "Y":
                                score2 += 5;
                                break;
                            
                            case "Z":
                                score2 += 9;
                                break;
                        }
                        break;
                    
                    case "C":
                        switch (player)
                        {
                            case "X":
                                score2 += 2;
                                break;
                            
                            case "Y":
                                score2 += 6;
                                break;
                            
                            case "Z":
                                score2 += 7;
                                break;
                        }
                        break;
                }
            }
            
            Console.WriteLine($"Your score is {score1}");
            Console.WriteLine($"Your new score is {score2}");
        }
    }
}