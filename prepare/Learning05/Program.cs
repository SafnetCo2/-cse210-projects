using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        //mathAssignment

        MathAssignment mathAssignment = new MathAssignment("Roberto Carlos", "Fraction", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());

        //writingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters ", "European History","The Causes of World War II");
        
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
    
}