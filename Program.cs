
Console.WriteLine("choose your weapon...");
int weapon = 0;
string read = "";
int winTracker = 0;
int lossTracker = 0;
Random random = new Random();
int compChoice = 0;

while (read != "stop")
{
    while (weapon == 0)
    {
        read = Console.ReadLine();
        if (read == "r" || read == "rock")
        {
            weapon = 1;
        }
        else if (read == "p" || read == "paper")
        {
            weapon = 2;
        }
        else if (read == "s" || read == "scissors")
        {
            weapon = 3;
        }
        else
        {
            Console.WriteLine("Invalid! try r/rock, p/paper or s/scissors");
        }
    }


    compChoice = random.Next(1, 4);

    if (weapon + 1 == compChoice || compChoice + 2 == weapon)
    {
        Console.WriteLine("You lost!");
        lossTracker++;
        Console.WriteLine($"win count: {winTracker}");
        Console.WriteLine($"loss count: {lossTracker}");
        
    }
    else if (compChoice + 1 == weapon || compChoice - 2 == weapon)
    {
        Console.WriteLine("You won!");
        winTracker++;
        Console.WriteLine($"win count: {winTracker}");
        Console.WriteLine($"loss count: {lossTracker}");
        
    }
    else
    {
        Console.WriteLine("Draw!");
        Console.WriteLine($"win count: {winTracker}");
        Console.WriteLine($"loss count: {lossTracker}");
    }

    weapon = 0;

}