using System.Diagnostics.Metrics;

while (true)
{
    Console.WriteLine("Find the number between 0 and 100!");
    Random random = new Random();
    int randomNumber = random.Next(0, 11);
    int Guesses = 0;

    while (true)
    {
        Console.WriteLine("Enter a number:");
        string? input = Console.ReadLine();

        if (input == "")
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }

        if (!int.TryParse(input, out int guess))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }

        Guesses++;

        if (guess == randomNumber)
        {
            // This doesn't work when you don't use numbers because Int.Parse only does numbers.
            // It says invalid input when you don't use anything and asks the question again.
                
            Console.WriteLine($"You guessed the number!");
            Console.WriteLine($"You guessed the number in {Guesses} guesses.");
                break;
        }
        else if (guess < randomNumber)
        {
            Console.WriteLine("The number is higher than your guess.");
        }
        else
        {
            Console.WriteLine("The number is lower than your guess.");

        }
    }
}