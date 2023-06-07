int inputNumber = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int sum = 0;

for (int i = 0; i < inputNumber; i++)
{
    int randomNumber = rand.Next() % 100;
    sum += randomNumber;
}

Console.WriteLine(sum);
Console.WriteLine((double)sum / inputNumber);

Console.ReadKey();