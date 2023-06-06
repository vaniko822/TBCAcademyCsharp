Console.WriteLine("Sheiyvane Diapazonis Minimumi: ");
int inputMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sheiyvane Diapazonis Maqsimumi: ");
int inputMax = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();
int randomNumber = rand.Next(inputMin, inputMax);
int sum = 0;

while (true)
{
    int guessNumber = Convert.ToInt32(Console.ReadLine());
    if (guessNumber == randomNumber)
    {
        Console.WriteLine("Shen dagchirda - " + sum + " Mcdeloba");
        Console.WriteLine("Gsurs tamashis gagrdzeleba? Yes/No");
        string inputAnswer = Console.ReadLine();
        if (inputAnswer == "Yes")
        {
            sum = 0;
            Console.WriteLine("Sheiyvane Diapazonis Minimumi: ");
            inputMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sheiyvane Diapazonis Maqsimumi: ");
            inputMax = Convert.ToInt32(Console.ReadLine());
            randomNumber = rand.Next(inputMin, inputMax);
        }
        else
        {
            break;
        }
    }
    else
    {
        sum++;
    }
}

Console.ReadKey();