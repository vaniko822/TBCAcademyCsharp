Console.WriteLine("Sheiyvanet piramidis simagle: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < inputNumber; i++)
{
    for (int j = 0; j < inputNumber - i - 1; j++)
    {
        Console.Write(" ");
    }

    for (int k = 0; k <= i * 2; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

Console.ReadKey();