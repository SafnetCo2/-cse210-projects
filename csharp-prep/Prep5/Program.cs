using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        Console.WriteLine();
        string userName = PromptUserName();
        Console.WriteLine($"Hello,{userName}!");
        Console.WriteLine();
        int favoriteNumber = PromptUserNumber();
        Console.WriteLine($"my favorite number is {favoriteNumber}");

        int squaredNumber = SquaredNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);
    }
//function to display Welcome


    //prompt username functions
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;


    }
    static int PromptUserNumber()
        {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;

            
        }
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello, Welcome to the Program");
    }
    //square function
    static int SquaredNumber(int number)
    {
        return number* number;
    }
    
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName} if  squared the number is {squaredNumber}");
    }
}

    

