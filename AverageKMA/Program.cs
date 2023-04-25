using System;

namespace AverageKMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            if (n >= 3)
            {
                double[] seperatedInput = new double[n];

                for (int i = 0; i <= n; i++)
                {
                    if (i >= 0 && i < 2)
                    {
                        seperatedInput[i] = i + 1;
                    }
                    else if (i == 2)
                    {
                        double temp = (i + (seperatedInput[i - 2])) / 2.0;
                        seperatedInput[i] = temp;
                    }
                    else if (i > 2 && i < n)
                    {
                        double temp2 = ((seperatedInput[i - 2]) + (seperatedInput[i - 1])) / 2.0;
                        seperatedInput[i] = temp2;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("result");
                    Console.WriteLine((i + 1) + " " + seperatedInput[i]);
                }
            }
        }
    }
}
