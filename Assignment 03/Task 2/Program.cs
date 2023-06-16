int inputNumber = Convert.ToInt32(Console.ReadLine());
int inputNumber2 = inputNumber;
int sum = 0;

while (inputNumber > 0)
{
    inputNumber--;
    if (inputNumber == 0)
    {
        break;
    }
    else if (inputNumber2 % inputNumber == 0)
    {
        sum++;
    }
}
Console.WriteLine(sum);

Console.ReadKey();