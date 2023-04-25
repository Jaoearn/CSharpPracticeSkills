using System;

namespace A_B__Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value1:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value2:");
            int value2 = Convert.ToInt32(Console.ReadLine());
            if (value1 >= 10000 || value2 >= 10000)
            {
                Console.WriteLine("Error");
            }
            else if (value1 <= 0 || value2 <= 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("value1 + value2 = " + value1 + value2);
            }
        }
    }
}
