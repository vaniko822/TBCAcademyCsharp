Console.WriteLine("Sheiyvanet pirveli masivis zoma: ");
int arraySize = int.Parse(Console.ReadLine());

string[] arrayStrings = new string[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"Sheiyvanet {i+1} elementi: ");
    string arrayString = Console.ReadLine();
    arrayStrings[i] = arrayString;
}

Console.WriteLine("Sheiyvanet meore masivis zoma: ");
int array2Size = int.Parse(Console.ReadLine());

int[] arrayNumbers = new int[array2Size];

for (int i = 0; i < array2Size; i++)
{
    Console.WriteLine($"Sheiyvanet {i + 1} elementi: ");
    int arrayNumber = int.Parse(Console.ReadLine());
    arrayNumbers[i] = arrayNumber;
}

Console.WriteLine("pasuxi: ");
if (arraySize == array2Size)
{
    for(int i = 0; i < arraySize ; i++)
    {
        Console.Write($"{arrayNumbers[i]} " + $"{arrayStrings[i]} " );
    }
}