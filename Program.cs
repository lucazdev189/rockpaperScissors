string yesNo = "Yes";

Console.WriteLine("Written by lucazdev189");

while (yesNo == "Yes")
{
    Console.WriteLine("Rock, Paper, or Scissors?");
    string answer = Convert.ToString(Console.ReadLine());

    Random computerMove = new Random();
    int aiMove = computerMove.Next(1, 4);

    if (aiMove == 1)
    {
        if (answer == "Rock")
        {
            Console.WriteLine("Rock");
            Console.WriteLine("Tie!");
        }
        if (answer == "Paper")
        {
            Console.WriteLine("Rock");
            Console.WriteLine("You Win!");
        }
        if (answer == "Scissors")
        {
            Console.WriteLine("Rock");
            Console.WriteLine("You Lose!");
        }
    }

    else if (aiMove == 2)
    {
        if (answer == "Rock")
        {
            Console.WriteLine("Paper");
            Console.WriteLine("You Lose!");
        }
        if (answer == "Paper")
        {
            Console.WriteLine("Paper");
            Console.WriteLine("Tie!");
        }
        if (answer == "Scissors")
        {
            Console.WriteLine("Paper");
            Console.WriteLine("You Win!");
        }
    }

    else if (aiMove == 3)
    {
        if (answer == "Rock")
        {
            Console.WriteLine("Scissors");
            Console.WriteLine("You Win!");
        }
        if (answer == "Paper")
        {
            Console.WriteLine("Scissors");
            Console.WriteLine("You Lose!");
        }
        if (answer == "Scissors")
        {
            Console.WriteLine("Scissors");
            Console.WriteLine("Tie!");
        }
    }

    Console.WriteLine("Again?");
    yesNo = Convert.ToString(Console.ReadLine());
}