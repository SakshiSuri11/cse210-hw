using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberInput = Console.ReadLine();
        int favoriteNumber;
        while (!int.TryParse(numberInput, out favoriteNumber))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            Console.Write("Please enter your favorite number: ");
            numberInput = Console.ReadLine();
        }
        return favoriteNumber;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"\nHello, {name}! Your favorite number squared is: {squaredNumber}");
    }

}