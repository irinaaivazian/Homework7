namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            bool isPalindrome = true;
            int length = inputString.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (inputString[i] != inputString[length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");

            }
        }
    }
}
