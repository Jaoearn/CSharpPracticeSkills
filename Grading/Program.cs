using System;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Exam Score:");
            int ExamScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Midterm Score:");
            int MidtermScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Final Score:");
            int FinalScore = Convert.ToInt32(Console.ReadLine());

            if (ExamScore > 30 || MidtermScore > 30 || FinalScore > 40)
            {
                Console.WriteLine("Error");
            }
            else if (ExamScore < 0 || MidtermScore < 0 || FinalScore < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                int totalScore = ExamScore + MidtermScore + FinalScore;
                Console.WriteLine("Total Score is " + totalScore);
                if (totalScore > 100) Console.WriteLine("Error");
                else if (totalScore < 0) Console.WriteLine("Error");
                else if (totalScore > 90) Console.WriteLine("Grade A+");
                else if (totalScore > 70) Console.WriteLine("Grade B+");
                else if (totalScore > 50) Console.WriteLine("Grade C+");
                else if (totalScore > 30) Console.WriteLine("Grade C");
                else Console.WriteLine("Grade F");
            }
        }
    }
}
