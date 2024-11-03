using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        
        List <int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a list of numbers: ");
        do
        {
            Console.Write("Enter a number");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        int sum = numbers.Sum();
        Console.WriteLine($"sum is {sum}");
        //average
        double average = numbers.Average();
        Console.WriteLine($"the average: {average}");

        //maximum number
        int max = numbers.Max();
        Console.WriteLine($"maximum number is: {max}");
        
    }
}