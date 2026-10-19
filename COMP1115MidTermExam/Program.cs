Console.WriteLine("Welcome to the guessing game, guess a number betweem 1-100 you get 7 tries.");

int randomNumber = new Random().Next(1, 100);
int PlayerNum = int.Parse(Console.ReadLine());

for (int i = 0; i < 7; i = i + 1)
{
    if (PlayerNum == randomNumber)
    {
        Console.WriteLine("You got it!");
        break;
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

    
} 