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

for(int i = 0;i < arraySize; i++)
{
    array3[i] = arrayNumbers[i];
}
for (int i = 0; i < arraySize2; i++)
{
    array3[arraySize+i] = arrayNumbers2[i];
}

foreach (int i in array3)
{
    Console.Write(i + " ");
}

int maxLength = 0;
int startIndex = 0;
int currentLength = 1;
int currentStartIndex = 0;

for (int i = 1; i < array3.Length; i++)
{
    if (array3[i] > array3[i - 1])
    {
        currentLength++;

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            startIndex = currentStartIndex;
        }
    }
    else
    {
        currentLength = 1;
        currentStartIndex = i;
    }
}

for (int i = startIndex; i < startIndex + maxLength; i++)
{
    Console.Write(array3[i] + " ");
}