using System;

public class GuessGame
{
    private int numberToGuess;
    private Random random;

    public GuessGame()
    {
        random = new Random(); //create a new random obj
        numberToGuess = random.Next(1, 101); // Random number between 1 and 100
    }

    public void Start()
    {
        int userGuess = 0;
        Console.WriteLine("Welcome to the Guess the Number Game!");
        Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");

        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            string?input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {
                if (userGuess < numberToGuess)
                    Console.WriteLine("Too low! Try again.");
                else if (userGuess > numberToGuess)
                    Console.WriteLine("Too high! Try again.");
                else
                    Console.WriteLine("Congratulations! You guessed the correct number.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
