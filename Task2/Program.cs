namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter a character to count: ");
            char characterToCount = Console.ReadLine()[0];

            int count = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == characterToCount)
                {
                    count++;
                }
            }

            Console.WriteLine("The character '{0}' appears {1} times in the string.", characterToCount, count);
        }
    }
}
