namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            int originalNumber = number;
            int sum = 0;
            int numberOfDigits = number.ToString().Length;

            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                number /= 10;
            }

            if (sum == originalNumber)
            {
                Console.WriteLine("{0} is an Armstrong number.", originalNumber);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number.", originalNumber);
            }
        }
    }
    
}
