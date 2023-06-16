Console.WriteLine("Sheiyvanet masivis zoma: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arrayNumbers = new int[arraySize];

Console.WriteLine("Sheiyvanet masivis elementebi: ");
for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"[{i}]");
    int arrayNumber = int.Parse(Console.ReadLine());
    arrayNumbers[i] = arrayNumber;
}

for (int i = 0; i < arraySize - 1; i++)
{
    for (int j = 0; j < arraySize - i - 1; j++)
    {
        if (arrayNumbers[j] > arrayNumbers[j + 1])
        {
            int temp = arrayNumbers[j];
            arrayNumbers[j] = arrayNumbers[j + 1];
            arrayNumbers[j + 1] = temp;
        }
    }
}

Console.WriteLine("Dalagebuli masivi: ");
foreach (int number in arrayNumbers)
{
    Console.Write(number + " ");
}