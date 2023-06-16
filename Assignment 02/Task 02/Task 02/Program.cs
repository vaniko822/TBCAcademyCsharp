Console.WriteLine("Airchie qva/qagaldi/makrateli");
string playerMove = Console.ReadLine();

Random rand = new Random();
int randNumber = rand.Next(1, 4);
string computerMove;

if (randNumber == 1)
{
    computerMove = "qva";
}
else if (randNumber == 2)
{
    computerMove = "qagaldi";
}
else
{
    computerMove = "makrateli";
}


if (playerMove == computerMove)
{
    Console.WriteLine("Frea!");
}
else if (
    (playerMove == "qva" && computerMove == "makrateli") ||
    (playerMove == "qagaldi" && computerMove == "qva") ||
    (playerMove == "makrateli" && computerMove == "qagaldi"))
{
    Console.WriteLine("Moige!");
}
else
{
    Console.WriteLine("Damarcxdi!");
}