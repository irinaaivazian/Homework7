namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 50;

            Console.WriteLine("Enter 50 integers:");

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            double average = (double)sum / count;

            Console.WriteLine("The average of the entered numbers is: " + average);
        }
    }
}
