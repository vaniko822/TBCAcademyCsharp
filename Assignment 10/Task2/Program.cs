using Task2;

Console.WriteLine("Enter sides of first triangle:");

Console.WriteLine("Side 1:");
double side1 = double.Parse(Console.ReadLine());
Console.WriteLine("Side 2:");
double side2 = double.Parse(Console.ReadLine());
Console.WriteLine("Side 3:");
double side3 = double.Parse(Console.ReadLine());

Triangle t1 = new Triangle(side1, side2, side3);
Console.WriteLine($"Is it a valid triangle? - {t1.checkEqualityTriangle()}");

Console.WriteLine("Enter sides of second triangle:");

Console.WriteLine("Side 1:");
double t2Side_1 = double.Parse(Console.ReadLine());
Console.WriteLine("Side 2:");
double t2Side_2 = double.Parse(Console.ReadLine());
Console.WriteLine("Side 3:");
double t2Side_3 = double.Parse(Console.ReadLine());

Triangle t2 = new Triangle(t2Side_1, t2Side_2, t2Side_3);
Console.WriteLine($"Is it a valid triangle? - {t2.checkEqualityTriangle()}");

// Parameter
double t1p = t1.Parameter();
Console.WriteLine($"First Triangle Parameter - {t1p}");
double t2p = t2.Parameter();
Console.WriteLine($"Second Triangle Parameter - {t2p}");

// Area
double t1a = t1.Area();
Console.WriteLine($"First Triangle Area - {t1a}");
double t2a = t2.Area();
Console.WriteLine($"Second Triangle Area - {t2a}");

// ==
bool result = t1 == t2;
Console.WriteLine($"Triangle 1 == Triangle2 ? - {result}");

// !=
bool result2 = t1 != t2;
Console.WriteLine($"Triangle 1 != Triangle2 ? - {result2}");

// <
bool result3 = t1 < t2;
Console.WriteLine($"Triangle 1 < Triangle2 ? - {result3}");

// >
bool result4 = t1 > t2;
Console.WriteLine($"Triangle 1 > Triangle2 ? - {result4}");

// +
var result5 = t1 + t2;
Console.WriteLine($"Triangle3 - {result5.S1}, {result5.S2}, {result5.S3}");


// Equilateral triangle
double side = double.Parse(Console.ReadLine());
Triangle equilateralTriangle = (Triangle)side;

double equilateralTriangleParameter = equilateralTriangle.Parameter();
Console.WriteLine($"Equilateral triangle parameter - {equilateralTriangleParameter}");

double equilateralTriangleArea = equilateralTriangle.Area();
Console.WriteLine($"Equilateral triangle Area - {equilateralTriangleArea}");


Console.ReadKey();