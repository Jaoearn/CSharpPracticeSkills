using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer:");
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> num = new List<int>();

            while (input > 0)
            {
                Console.WriteLine("Please enter another integer (enter 0 for cal): ");
                input = Convert.ToInt32(Console.ReadLine());
                num.Add(input);
            }

            int max = num.Max();
            int min = num.Where(x => x != 0).Min();
            Console.WriteLine("Max Number is " + max);
            Console.WriteLine("Min Number is " + min);
        }
    }
}
