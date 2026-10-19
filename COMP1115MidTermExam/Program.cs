
Console.WriteLine("Welcome to the guessing game, guess a number betweem 1-100 you get 7 tries.");

int randomNumber = new Random().Next(1, 100);
int PlayerNum = int.Parse(Console.ReadLine());

for (int i = 0; i < 6; i = i + 1)
{
    if (PlayerNum < 1 || PlayerNum > 100)
    {
        Console.WriteLine("Please enter a number between 1 and 100");
        PlayerNum = int.Parse(Console.ReadLine());
        continue;
    }
    else if (PlayerNum < randomNumber)
    {
        Console.WriteLine("Guess higher");
        PlayerNum = int.Parse(Console.ReadLine());
    }
    else if (PlayerNum > randomNumber)
    {
        Console.WriteLine("Guess lower");
        PlayerNum = int.Parse(Console.ReadLine());
    }
    else if (PlayerNum == randomNumber)
    {
        Console.WriteLine("You got it!");
        if (i == 1)
        {
            Console.WriteLine(" get 100 points!");
        }
        else if (i == 2)
        {
            Console.WriteLine(" get 90 points!");
        }
        else if (i == 3)
        {
            Console.WriteLine(" get 80 points!");
        }
        else if (i == 4)
        {
            Console.WriteLine(" get 70 points!");
        }
        else if (i == 5)
        {
            Console.WriteLine(" get 60 points!");
        }
        else if (i == 6)
        {
            Console.WriteLine(" get 50 points!");
        }

    }
    else
    {
        Console.WriteLine("You've used up all your tries, the number was " + randomNumber);
    }
}
