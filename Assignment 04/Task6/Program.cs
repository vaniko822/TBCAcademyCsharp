Console.WriteLine("Sheiyvanet pirveli matricis rigis-s N zoma: ");
int arrayN = int.Parse(Console.ReadLine());
Console.WriteLine("Sheiyvanet pirveli matricis column-is M zoma: ");
int arrayM = int.Parse(Console.ReadLine());

int[,] array = new int[arrayN, arrayM];

for (int row = 0; row < arrayN; row++)
{
    for(int col = 0; col < arrayM; col++)
    {
        Console.WriteLine($"[{row}][{col}]");
        int number = int.Parse(Console.ReadLine());
        array[row, col] = number;
    }
}

Console.WriteLine("Sheiyvanet pirveli matricis rigis-s M zoma: ");
int arrayM2 = int.Parse(Console.ReadLine());
Console.WriteLine("Sheiyvanet pirveli matricis column-is K zoma: ");
int arrayK = int.Parse(Console.ReadLine());

int[,] array2 = new int[arrayM2, arrayK];

for (int row = 0; row < arrayM2; row++)
{
    for (int col = 0; col < arrayK; col++)
    {
        Console.WriteLine($"[{row}][{col}]");
        int number = int.Parse(Console.ReadLine());
        array2[row, col] = number;
    }
}

if(arrayM == arrayM2)
{
    int[,] resultMatrix = new int[arrayN, arrayK];

    for (int i = 0; i < arrayN; i++)
    {
        for (int j = 0; j < arrayK; j++)
        {
            int sum = 0;
            for (int k = 0; k < arrayM; k++)
            {
                sum += array[i, k] * array2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    Console.WriteLine("Matricis shedegi: ");

    for (int i = 0; i < arrayN; i++)
    {
        for (int j = 0; j < arrayK; j++)
        {
            Console.Write(resultMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Matricebis gamravleba sheudzlebelia.");
}