namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101); // Generates a random number between 1 and 100 (inclusive)
            int userGuess = 0;

            Console.WriteLine("Guess the number between 1 and 100:");

            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }

            Console.WriteLine("Congratulations! You guessed the correct number: " + numberToGuess);
        }
    }
}
