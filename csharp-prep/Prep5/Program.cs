using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        string userName = PromptUserName();
        Console.WriteLine($"Hello,{userName}!");

        int favoriteNumber = PromptUserNumber();
        Console.WriteLine($"my favorite number is {favoriteNumber}");

        int squaredNumber = SquaredNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);
    }
//function to display Welcome
static void DisplayWelcome()
    {
        Console.WriteLine("Hello Welcome to the Program");
    }
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

    

