namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            int sumOfEvenDigits = 0;

            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sumOfEvenDigits += digit;
                }
                number /= 10;
            }

            Console.WriteLine("The sum of even digits is: " + sumOfEvenDigits);
        }
    }
    
}
