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
            

            Console.WriteLine($"The magic number is {magicNumber}."); 
            Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!");

            
            while (true)
            {
                Console.Write("What is your guess? ");

                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 100)
                {
                    Console.Write("Please enter a valid number between 1 and 100: ");
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
                    Console.WriteLine($"You guessed it! The magic number was {magicNumber}. It took you {guessCount} guesses.");
                    break; 
                }
            }

        
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes"); 

        Console.WriteLine("Thanks for playing! See you soon!");
    }
}
