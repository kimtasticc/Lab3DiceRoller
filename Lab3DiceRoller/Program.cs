bool playAgain;
do
{
    Console.WriteLine("Hello and welcome to Dice Roller!");

    GenerateDiceRoll();

    Console.WriteLine("Would you like to roll again (y/n)?");
    string input = Console.ReadLine();
    playAgain = input.ToLower() == "y";


    void GenerateDiceRoll()
    {
        bool diceSidesInput = false;
        int diceSides = 0;

        while (!diceSidesInput)
        {
            Console.WriteLine("Please enter the number of sides you want for your pair of dice: ");
            diceSidesInput = int.TryParse(Console.ReadLine(), out diceSides);

            if (!diceSidesInput)
            {
                Console.WriteLine("Please only give me a number. Try again!");
            }
        }

        Console.WriteLine($"Excellent, you will be rolling two {diceSides} sided dice. Press any key to roll your dice!");
        Console.ReadKey();

        int diceNumber1 = RandomDiceRoll(diceSides);
        int diceNumber2 = RandomDiceRoll(diceSides);
        int diceTotal = diceNumber1 + diceNumber2;

        Console.WriteLine($"You rolled a {diceNumber1} and a {diceNumber2}!");
        Console.WriteLine($"That gives you a total of {diceTotal}!");

        if (diceSides == 6)
        {
            Console.WriteLine(SixSidedMessage(diceNumber1, diceNumber2, diceTotal));
        }
    }

    string SixSidedMessage(int diceNumber1, int diceNumber2, int diceTotal)
    {
        string message;
        if (diceTotal == 2)
        {
            message = "Snake Eyes!!!";
        }
        else if (diceTotal == 3)
        {
            message = "Ace Deuce!!!";
        }
        else if (diceNumber1 == 6 && diceNumber2 == 6)
        {
            message = "Nice! Box Cars!!";
        }
        else if (diceTotal == 7 || diceTotal == 11)
        {
            message = "Awesome! Win!!";
        }
        else
        {
            message = "";
        }
        if (diceTotal == 2 || diceTotal == 3 || diceTotal == 12)
            {
                Console.WriteLine("That's some good luck if you're playing Craps! (I think?? I know nothing about this game)");
            }
        return message;
    }

    int RandomDiceRoll(int diceSides)
    {
        Random RandomDiceNumber = new Random();

        return RandomDiceNumber.Next(1, diceSides);
    }
} while (playAgain == true);


