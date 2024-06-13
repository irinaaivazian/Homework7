namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "rock", "paper", "scissors" };
            Random random = new Random();
            int computerChoiceIndex = random.Next(0, 3);
            string computerChoice = options[computerChoiceIndex];

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.Write("Enter your choice (rock, paper, or scissors): ");
            string userChoice = Console.ReadLine().ToLower();

            Console.WriteLine("Computer chose: " + computerChoice);

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
        }
    }
}
