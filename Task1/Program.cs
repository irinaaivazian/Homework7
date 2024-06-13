using System.Runtime.ExceptionServices;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;
            for (int i = 1; i <= 10;  i++) 
            {
               int number = int.Parse(Console.ReadLine());
                
               if (number > maxNumber) 
               {
                    maxNumber = number;
               }
                
            }
            Console.WriteLine(maxNumber);
        }
    }
}
