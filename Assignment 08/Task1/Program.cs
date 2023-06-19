
using Task1;

var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());

int Add = Calculator.Add( a, b );
int Subtract = Calculator.Subtract( a, b );
int Multiply = Calculator.Multiply( a, b );
int Divide = Calculator.Divide( a, b );
double Pow = Calculator.Pow( a, b );
double Sqrt = Calculator.Sqrt(a);

Console.WriteLine(
    $"Add - {Add} " + "\n" +
    $"Subtract - {Subtract} " + "\n" +
    $"Multiply - {Multiply} " + "\n" +
    $"Divide - {Divide} " + "\n" +
    $"Pow - {Pow} " + "\n" +
    $"Sqrt - {Sqrt} " + "\n" 
    );