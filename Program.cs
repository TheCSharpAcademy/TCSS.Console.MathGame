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

if (char.ToLower(userOption) == 'a')
{
    Console.WriteLine("Addition Selected");
}
else if (char.ToLower(userOption) == 's')
{
    Console.WriteLine("Subtraction selected");
}
else if (char.ToLower(userOption) == 'm')
{
    Console.WriteLine("Multiplication selected");
}
else if (char.ToLower(userOption) == 'd')
{
    Console.WriteLine("Division selected");
}
else if (char.ToLower(userOption) == 'v')
{
    Console.WriteLine("View previous games selected");
}
else if (char.ToLower(userOption) == 'q')
{
    Console.WriteLine("Goodbye");
}
else
{
    Console.WriteLine("Invalid input");
}

