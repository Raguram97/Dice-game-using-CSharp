int playerRandomNum;
int enemyRandomNum;

int playerScore = 0;
int enemyScore = 0;
Random random = new Random();

for  (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any key to roll the dice");
    Console.ReadKey();

    playerRandomNum = random.Next(1,7);
    Console.WriteLine($"You rolled a {playerRandomNum}");

    Console.WriteLine("...");

    Thread.Sleep(1000);

    enemyRandomNum = random.Next(1,7);
    Console.WriteLine($"Enemy AI rolled a {enemyRandomNum}");

    if (playerRandomNum > enemyRandomNum)
    {
        playerScore++;
        Console.WriteLine("You won this round");
    }
    else if (enemyRandomNum > playerRandomNum)
    {
        enemyScore++;
        Console.WriteLine("You lose this round");
    }
    else
    {
        Console.WriteLine("This round is draw!");
    }

    Console.WriteLine($"Your score is: {playerScore} & enemy score is: {enemyScore}");

}
Console.WriteLine();
if(playerScore > enemyScore)
{
    Console.WriteLine("YOU WIN!!");
}
else if (enemyScore > playerScore)
{
    Console.WriteLine("YOU LOSE");
}
else
{
    Console.WriteLine("DRAW!");
}
Console.ReadKey();