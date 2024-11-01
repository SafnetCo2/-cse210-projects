using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter marks (0-100): ");
        int marks = int.Parse(Console.ReadLine());
        char grade;

        if (marks >= 90)
        {
            grade = 'A';
        }
        else if (marks >= 80)
        {
            grade = 'B';
        }
        else if (marks >= 70)
        {
            grade = 'C';
        }
        else if (marks >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'E';
        }

        Console.WriteLine($"The letter grade is: {grade}");
        if (marks >= 70) 
        {
            Console.WriteLine($"Congratulations passed Exam!");
        }
        else
        {
            Console.WriteLine($"failed try again please");
        }
    }
}
