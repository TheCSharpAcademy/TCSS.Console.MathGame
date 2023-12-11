Console.WriteLine($"What's your name?");
string name = Console.ReadLine();
DateTime date = DateTime.Now;
int gamesPlayed = 0;
char userOption;
decimal averageScore;
bool isScoreEmpty = true;

Console.WriteLine($"Hello {name}! Today is {date}. This is your math's game. It's great that you're working on improving yourself.\n");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();
Console.Clear();
Console.WriteLine($"Games played: {gamesPlayed}");
Console.WriteLine(@"What game would you like to play?
A - Addition
S - Subtraction
M - Multiplication
D - Division
V - View Previous Games
Q - Quit The Program");

userOption = Console.ReadKey().KeyChar;

switch (char.ToLower(userOption))
{
    case 'a':
        AdditionGame("You're playing an addition game");
        break;
    case 's':
        SubtractionGame("You're playing a subtraction game");
        break;
    case 'm':
        MultiplicationGame("You're playing a multiplication game");
        break;
    case 'd':
        DivisionGame("You're playing a division game");
        break;
    case 'v':
        ViewPreviousGames("List of Games");
        break;
    case 'q':
        Console.WriteLine("Goodbye");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

void AdditionGame(string message) 
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void ViewPreviousGames(string message)
{
    Console.WriteLine(message);
}

