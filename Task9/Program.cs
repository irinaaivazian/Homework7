namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            int wordCount = 0;
            bool inWord = false;

            foreach (char c in sentence)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (inWord)
                    {
                        wordCount++;
                        inWord = false;
                    }
                }
                else
                {
                    inWord = true;
                }
            }

            if (inWord)
            {
                wordCount++;
            }

            Console.WriteLine("The number of words in the sentence is: " + wordCount);
        }
    }
}
