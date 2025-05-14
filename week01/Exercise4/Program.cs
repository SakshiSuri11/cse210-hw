using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int userInput;
        Console.WriteLine("Enter a series of numbers (enter 0 to stop):");

        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userInput))
            {
                if (userInput != 0)
                {
                    numbers.Add(userInput);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
                userInput = -1; // Ensure the loop continues if invalid input is given
            }
        }
            while (userInput != 0) ;
                Console.WriteLine("\nNumbers you entered:");
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();

        // Part 1: Compute the sum
        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            Console.WriteLine($"The sum of the numbers is: {sum}");
        }



        // Part 2: Compute the average
            double average = numbers.Average();
            Console.WriteLine($"The average is: {average}");

            // Part 3: Find the maximum
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    // if this number is greater than the max, we have found the new max!
                    max = number;
                }
            }

            Console.WriteLine($"The max is: {max}");

           



    }
}
