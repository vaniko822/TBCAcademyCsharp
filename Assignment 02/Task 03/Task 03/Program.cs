int year = Convert.ToInt32(Console.ReadLine());

int startSignYear = 1900;
int zodiacSign = (year - startSignYear) % 12;

switch (zodiacSign)
{
    case 0:
        Console.WriteLine("virtxa");
        break;
    case 1:
        Console.WriteLine("xari");
        break;
    case 2:
        Console.WriteLine("vefxvi");
        break;
    case 3:
        Console.WriteLine("kurdgeli");
        break;
    case 4:
        Console.WriteLine("drakoni");
        break;
    case 5:
        Console.WriteLine("gveli");
        break;
    case 6:
        Console.WriteLine("cxeni");
        break;
    case 7:
        Console.WriteLine("cxvari");
        break;
    case 8:
        Console.WriteLine("maimuni");
        break;
    case 9:
        Console.WriteLine("mamali");
        break;
    case 10:
        Console.WriteLine("dzagli");
        break;
    case 11:
        Console.WriteLine("gori");
        break;
}