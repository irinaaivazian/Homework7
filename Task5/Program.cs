namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Even numbers between {0} and {1} are:", start, end);

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

