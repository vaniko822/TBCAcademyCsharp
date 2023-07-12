using System;
using System.Transactions;
using Task1;


while (true)
{
    Console.WriteLine("1. Add" + '\n' +
    "2. Subtract" + '\n' +
    "3. Multiply" + '\n' +
    "4. Divide" + '\n' +
    "5. Pow" + '\n' +
    "6. Sqrt" + '\n' +
    "7. Close"
    );

    var choose = int.Parse(Console.ReadLine());

    if (choose == 7)
    {
        break;
    }

    Console.WriteLine("Enter a number: ");
    var a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter b number: ");
    var b = int.Parse(Console.ReadLine());

    var del = new CalculatorDelegate(Calculator.Add);
    switch (choose)
    {
        case 1:
            del(a, b);
            break;
        case 2:
            del = Calculator.Subtract;
            del(a, b);
            break;
        case 3:
            del = Calculator.Multiply;
            del(a, b);
            break;
        case 4:
            del = Calculator.Divide;
            del(a, b);
            break;
        case 5:
            del = Calculator.Pow;
            del(a, b);
            break;
        case 6:
            CalculatorDelegateOneParam del2 = Calculator.Sqrt;
            del2(a);
            break;
    }
}


public delegate void CalculatorDelegate(double a, double b);
public delegate void CalculatorDelegateOneParam(double a);