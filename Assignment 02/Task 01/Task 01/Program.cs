Console.WriteLine("Sheiyvanet temperatura celsiusebshi: ");
string input = Console.ReadLine();
int temperature = Convert.ToInt32(input);

if (temperature < 0)
{
    Console.WriteLine("yinavs");
}
else if (temperature >= 0 && temperature <= 30)
{
    Console.WriteLine("Kargi Amindia");
}
else
{
    Console.WriteLine("Cxela");
}