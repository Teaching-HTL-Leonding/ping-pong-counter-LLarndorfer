// Lukas Larndorfer
//*Ping Pong

Console.Write("Judge, which type of game is it: ");
string gametype = (Console.ReadLine()!);
int player1score = 0;
int player2score = 0;
int player1wins = 0;
int player2wins = 0;
int player1winsoutput = 0;
int player2winsoutput = 0;
int custommatches;

switch (gametype)
{
    case ("short"):
        player1wins = 1;
        player2wins = 1;
        break;

    case ("regular"):
        player1wins = 4;
        player2wins = 4;
        break;

    case ("double"):
        player1wins = 3;
        player2wins = 3;
        break;

    case ("custom"):
        do
        {
            Console.Write("How moch matches do you want to play (even, minimum 1, max 10): ");
            custommatches = int.Parse(Console.ReadLine()!);
            player2wins = custommatches;
            player1wins = custommatches;
        } while (custommatches % 2 != 0 || custommatches! <= 0 || custommatches! >= 10);
        break;

    default:
        Console.WriteLine("You've entered wrong symbols. try again.");
        break;
}

int servicemaker = Random.Shared.Next(1,3);

while (player1score < 11 && player2score < 11 && player1wins > 0 && player2wins > 0)
{
    Console.Write("Player " + servicemaker + " makes the service. ");
    Console.WriteLine("Who scored the point? (1 for Player 1, 2 for Player 2 or q to quit)");
    var score = (Console.ReadLine()!);
    switch (score)
    {
        case "1":
            player1score = player1score + 1; 
            Console.WriteLine("Player 1 scored. New score: Player1 " + player1score + ":" + player2score + " Player2. Games: " + player1winsoutput + ":" + player2winsoutput + ".");
            break;

        case "2":
            player2score = player2score + 1;
            Console.WriteLine("Player 2 scored. New score: Player1 " + player1score + ":" + player2score + " Player2. Games: " + player1winsoutput + ":" + player2winsoutput + ".");
            break;

        case "q":
            Console.WriteLine("Match stops.");
            player2score = 777;
            break;

        default:
            Console.WriteLine("You've entered something wrong, try again.");
            break;

    }
    
if ((player1score + player2score) % 2 == 0)
{

    if (servicemaker == 1)
    {
        servicemaker = 2;
    }
    else 
    {
        servicemaker = 1;
    }
}
    if (player1score == 11)
    {
        Console.WriteLine("Player 1 won the game.");
        player1score = 0;
        player2score = 0;
        player1wins = player1wins - 1;
        player1winsoutput++;
    }

    else if (player2score == 11)
    {
        Console.WriteLine("Player 2 won the game.");
        player1score = 0;
        player2score = 0;
        player2wins = player2wins - 1;
        player2winsoutput++;

    }
}

if (player1wins == 0)
{
    Console.WriteLine("Player 1 won the match!");
}

if (player2wins == 0)
{
    Console.WriteLine("Player 2 won the match!");
}
