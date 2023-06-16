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

Console.WriteLine("Sheiyvanet masivis zoma: ");
int arraySize2 = int.Parse(Console.ReadLine());
int[] arrayNumbers2 = new int[arraySize2];

Console.WriteLine("Sheiyvanet masivis elementebi: ");
for (int i = 0; i < arraySize2; i++)
{
    Console.WriteLine($"[{i}]");
    int arrayNumber2 = int.Parse(Console.ReadLine());
    arrayNumbers2[i] = arrayNumber2;
}

int[] array3 = new int[arraySize + arraySize2];

for (int i = 0; i < arraySize; i++)
{
    array3[i] = arrayNumbers[i];
}
for (int i = 0; i < arraySize2; i++)
{
    array3[arraySize + i] = arrayNumbers2[i];
}

Console.WriteLine("Airchiet sasurveli dalagebis mimartuleba: " + "\n" +
    "1. (ASC) Zrdadobit" + "\n" +
    "2. (DESC) Klebadobit");

string sort = Console.ReadLine();

if (sort == "ASC")
{
    for (int i = 0; i < arraySize + arraySize2 - 1; i++)
    {
        for (int j = 0; j < arraySize + arraySize2 - i - 1; j++)
        {
            if (array3[j] > array3[j + 1])
            {
                int temp = array3[j];
                array3[j] = array3[j + 1];
                array3[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("Dalagebuli masivi: ");
    foreach (int number in array3)
    {
        Console.Write(number + " ");
    }
}
else
{
    for (int i = 0; i < arraySize + arraySize2 - 1; i++)
    {
        for (int j = 0; j < arraySize + arraySize2 - i - 1; j++)
        {
            if (array3[j] < array3[j + 1])
            {
                int temp = array3[j];
                array3[j] = array3[j + 1];
                array3[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("Dalagebuli masivi: ");
    foreach (int number in array3)
    {
        Console.Write(number + " ");
    }
}