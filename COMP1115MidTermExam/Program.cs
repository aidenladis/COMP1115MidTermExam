
Console.WriteLine("Welcome to the guessing game, guess a number betweem 1-100 you get 7 tries.");

int randomNumber = new Random().Next(1, 100);
int PlayerNum = int.Parse(Console.ReadLine());
int HightScore = 0;
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
            if (100 > HightScore)
            {
                HightScore = 100;
            }
        }
        else if (i == 2)
        {
            Console.WriteLine(" get 90 points!");
            if (90 > HightScore)
            {
                HightScore = 90;
            }
        }
        else if (i == 3)
        {
            Console.WriteLine(" get 80 points!");
            if (80 > HightScore)
            {
                HightScore = 80;
            }
        }
        else if (i == 4)
        {
            Console.WriteLine(" get 70 points!");
            if (70 > HightScore)
            {
                HightScore = 70;
            }
        }
        else if (i == 5)
        {
            Console.WriteLine(" get 60 points!");
            if (60 > HightScore)
            {
                HightScore = 60;
            }
        }
        else if (i == 6)
        {
            Console.WriteLine(" get 50 points!");
            if (50 > HightScore)
            {
                HightScore = 50;
            }
        }

    }
    Console.WriteLine("Your high score is: " + HightScore);
    Console.WriteLine("do you want to play again? yes or no");
    string playAgain = Console.ReadLine();
    if (playAgain == "yes")
    {
        randomNumber = new Random().Next(1, 100);
        Console.WriteLine("Welcome to the guessing game, guess a number betweem 1-100 you get 7 tries.");
        PlayerNum = int.Parse(Console.ReadLine());
        i = -1;
    }
    else if (playAgain == "no")
    {
        Console.WriteLine("Thanks for playing!");
        break;
        
    }
    
}
