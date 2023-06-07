int count = 0;
int sum = 0;

while (true)
{
    Console.WriteLine("Sheiyvanet Ricxvi: ");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    sum += inputNumber;
    ++count;
    Console.WriteLine("Jami: ");
    Console.WriteLine(sum);
    Console.WriteLine("Sashualo aritmetikuli: ");
    Console.WriteLine((decimal)sum/count);
}