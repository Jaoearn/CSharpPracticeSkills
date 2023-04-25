using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number:");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 2 || input == 3 || input == 5 || input == 7 || input == 11 || input == 19)
            {
                Console.WriteLine("Number is Prime.");
            }
            else if (input % 2 == 0 || input % 3 == 0 || input % 7 == 0)
            {
                Console.WriteLine("Number is not Prime.");
            }
            else if (input % 2 == 1)
            {
                Console.WriteLine("Number is Prime.");
            }
            else
            {
                Console.WriteLine("Number is not Prime.");
            }
        }
    }
}
