int inputNumber = Convert.ToInt32(Console.ReadLine());
int inputNumber2 = inputNumber;
int numberOfSeparators = 0;

while (inputNumber > 0)
{
    inputNumber--;
    if (inputNumber == 0)
    {
        break;
    }
    else if (inputNumber2 % inputNumber == 0)
    {
        numberOfSeparators++;
    }
}

if (numberOfSeparators > 2)
{
    Console.WriteLine("Shedgenili");
}
else
{
    Console.WriteLine("Martivi");
}

Console.ReadKey();