Console.WriteLine("-- Determinantis kalkulatori --");

Console.WriteLine("airchiet matricis zoma:" + "\n" + 
    "1. 2 x 2" + "\n" +  
    "2. 3 x 3:" );

int chooseMatrixSize = int.Parse(Console.ReadLine());

Console.WriteLine("Sheiyvanet elementebi: ");
if (chooseMatrixSize == 1)
{
    int[,] twoDimensionalMatrix = new int[2, 2];
    for (int i = 0; i < twoDimensionalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalMatrix.GetLength(1); j++)
        {
            Console.WriteLine($"[{i}][{j}]");
            int number = int.Parse(Console.ReadLine());
            twoDimensionalMatrix[i, j] = number;
        }
    }

    Console.WriteLine("Sheni Sheyvanili 2x2 matrica: ");
    for (int row = 0; row < 2; row++)
    {
        for (int col = 0; col < 2; col++)
        {
            Console.Write(twoDimensionalMatrix[row, col] + " ");
        }
        Console.WriteLine();
    }

    int determinanti = (twoDimensionalMatrix[0, 0] * twoDimensionalMatrix[1, 1]) - (twoDimensionalMatrix[0, 1] * twoDimensionalMatrix[1, 0]);
    Console.WriteLine($"Determinanti aris: {determinanti}");
}
else
{
    int[,] thirdDimensionalMatrix = new int[3, 3];
    for (int i = 0; i < thirdDimensionalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < thirdDimensionalMatrix.GetLength(1); j++)
        {
            Console.WriteLine($"[{i}][{j}]");
            int number = int.Parse(Console.ReadLine());
            thirdDimensionalMatrix[i, j] = number;
        }
    }

    Console.WriteLine("Sheni Sheyvanili 3x3 matrica: ");
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 3; col++)
        {
            Console.Write(thirdDimensionalMatrix[row, col] + " ");
        }
        Console.WriteLine();
    }

    int determinanti = 
        (thirdDimensionalMatrix[0, 0] * 
        (thirdDimensionalMatrix[1, 1] * thirdDimensionalMatrix[2,2] - thirdDimensionalMatrix[1, 2] * thirdDimensionalMatrix[2, 1]) -
        thirdDimensionalMatrix[0, 1] * 
        (thirdDimensionalMatrix[1, 0] * thirdDimensionalMatrix[2, 2] - thirdDimensionalMatrix[1, 2] * thirdDimensionalMatrix[2, 0]) +
        thirdDimensionalMatrix[0, 2] *
        (thirdDimensionalMatrix[1, 0] * thirdDimensionalMatrix[2, 1] - thirdDimensionalMatrix[1, 1] * thirdDimensionalMatrix[2, 0])
        );
    Console.WriteLine($"Determinanti aris: {determinanti}");
}