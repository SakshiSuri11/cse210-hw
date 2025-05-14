using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = -1;
        Console.WriteLine("Please enter a number between 1 and 101. Try to guess it!");

        while (guess != magicNumber)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low! Try guessing higher.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high! Try guessing lower.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number: " + magicNumber);
            }
        }
    }
}