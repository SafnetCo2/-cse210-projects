using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string playAgain;

        do
        {
            int magicNumber = random.Next(1, 101);
            int guess;
            int guessCount = 0;


            Console.WriteLine($"magic number is {magicNumber}.");
            Console.WriteLine("number is between 1 and 100. guess please!");


            while (true)
            {
                Console.Write(" your guess? ");

                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 100)
                {
                    Console.Write("Enter a valid number between 1 and 100: ");
                }

                guessCount++;


                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");

                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");

                }
                else
                {
                    Console.WriteLine($"Correct guessed it! The magic number was {magicNumber}. It took you {guessCount} guesses.");
                    break;
                }
            }


            Console.Write("play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine(" See you soon!");
    }
}
