Console.Clear();

bool replay = true;
bool playTrue = true;

while (playTrue)
{
    Console.WriteLine("You will enter two numbers that will be added together.");

    double num1;
    string input1 = "";

    Console.Write("Please enter the first number: ");
    input1 = Console.ReadLine()!;
    while (!Double.TryParse(input1, out num1))
    {
        Console.WriteLine("Invalid please try again");
        Console.Write("Please enter the first number: ");
        input1 = Console.ReadLine()!;
    }

    double num2;
    string input2 = "";

    Console.Write("Please enter the second number: ");
    input2 = Console.ReadLine()!;
    while (!Double.TryParse(input2, out num2))
    {
        Console.WriteLine("Invalid please try again");
        Console.Write("Please enter the second number: ");
        input2 = Console.ReadLine()!;
    }

    double total = (num1 + num2);
    Console.WriteLine($"{num1} + {num2} is equal to {total}.");

    while (replay)
    {
        Console.WriteLine("Do you want to play again? yes or no");
        string playAgain = Console.ReadLine()!.ToLower();
        if (playAgain == "yes")
        {
            replay = false;
        }
        else if (playAgain == "no")
        {
            replay = false;
            playTrue = false;
        }
        else
        {
            Console.WriteLine("Invalid answer. Try again");
            replay = true;
        }
    }
    replay = true;
}
Console.WriteLine("Thanks for playing!");