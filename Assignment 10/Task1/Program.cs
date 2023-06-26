using Task1;

int[,] matrixConsole = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"Enter the element [{i}, {j}]: ");
        string number = Console.ReadLine();
        matrixConsole[i, j] = int.Parse(number);
    }
}

Matrix matrix = new Matrix(matrixConsole);

Console.WriteLine("Matrix 1: ");
matrix.PrintMatrix();

int[,] matrixConsole2 = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"Enter the element [{i}, {j}]: ");
        string number = Console.ReadLine();
        matrixConsole2[i, j] = int.Parse(number);
    }
}

// Implicit conversion from int[,] to Matrix
Matrix matrix2 = matrixConsole2;
Console.WriteLine("Matrix 2: ");
matrix2.PrintMatrix();

// Equals()
var equals = matrix.Equals(matrix2);
Console.WriteLine($"Matrix1 is equals Matrix2? - {equals}");

// +
var sum = matrix + matrix2;

Console.WriteLine("Sum Matrix: ");
sum.PrintMatrix();

// -
var subtraction = matrix - matrix2;

Console.WriteLine("Subtraction Matrix: ");
subtraction.PrintMatrix();

// *
var multiplied = matrix * matrix2;

Console.WriteLine("Multiplied Matrix: ");
multiplied.PrintMatrix();

// (-)
var inversion = -matrix;
Console.WriteLine("Inversion Matrix: ");
inversion.PrintMatrix();

// ToString()
Console.WriteLine("Matrix ToString():");
Console.WriteLine(matrix.ToString());


Console.ReadKey();