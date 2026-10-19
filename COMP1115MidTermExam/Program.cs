
Console.WriteLine("Welcome to the guessing game. Guess a number between 1 and 100. You get 7 tries.");

int randomNumber = new Random().Next(1, 101);
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

        if (i < 5)
        {
            PlayerNum = int.Parse(Console.ReadLine());
        }
    }
    else if (PlayerNum > randomNumber)
    {
        Console.WriteLine("Guess lower");

        if (i < 5)
        {
            PlayerNum = int.Parse(Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine("You got it!");

        if (i == 0)
        {
            Console.WriteLine("You get 100 points!");
        }
        else if (i == 1)
        {
            Console.WriteLine("You get 90 points!");
        }
        else if (i == 2)
        {
            Console.WriteLine("You get 80 points!");
        }
        else if (i == 3)
        {
            Console.WriteLine("You get 70 points!");
        }
        else if (i == 4)
        {
            Console.WriteLine("You get 60 points!");
        }
        else if (i == 5)
        {
            Console.WriteLine("You get 50 points!");
        }
        else if (i == 6)
        {
            Console.WriteLine("You get 40 points!");
        }
    }

    if (i == 7 && PlayerNum != randomNumber)
    {
        Console.WriteLine("You lose, the number was " + randomNumber);
    }
}