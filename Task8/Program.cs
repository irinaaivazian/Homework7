namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Generating 10 random numbers between 1 and 100:");

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100 (inclusive)
                Console.WriteLine(randomNumber);
            }
        }
    }
}
