
using System;

class Program
{
    static int ReadValidScore()
    {
        int score;

        while (true)
        {
            Console.Write("Enter score (0-100): ");

            if (int.TryParse(Console.ReadLine(), out score)
                && score >= 0 && score <= 100)
            {
                return score;
            }

            Console.WriteLine("Invalid score! Try again.");
        }
    }

    static double CalculateAverage(int[] scores)
    {
        int sum = 0;

        foreach (int score in scores)
        {
            sum += score;
        }

        return (double)sum / scores.Length;
    }

    static string GetLetterGrade(double avg)
    {
        return avg >= 90 ? "A" :
               avg >= 80 ? "B" :
               avg >= 70 ? "C" :
               avg >= 60 ? "D" : "F";
    }

    static void PrintReport(int[] scores, double avg, string grade)
    {
        Console.WriteLine("\n--- Grade Report ---");

        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"Subject {i + 1}: {scores[i]}");
        }

        Console.WriteLine($"Average: {avg:F2}");
        Console.WriteLine($"Letter Grade: {grade}");
    }

    static void Main()
    {
        int[] scores = new int[3];

        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = ReadValidScore();
        }

        double avg = CalculateAverage(scores);
        string grade = GetLetterGrade(avg);

        PrintReport(scores, avg, grade);
    }
}
