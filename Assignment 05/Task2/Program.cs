Console.WriteLine("Sheiyvanet masivis zoma: ");
int arraySize = int.Parse(Console.ReadLine());

char[] arrayChars = new char[arraySize];

Console.WriteLine("Sheiyvanet masivis elementebi: ");
for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"[{i}]");
    char c = char.Parse(Console.ReadLine());
    arrayChars[i] = c;
}

Console.WriteLine("Sheiyvanet simbolo risi datvlac gsurt: ");
char ch = char.Parse(Console.ReadLine());

ElementebisDabruneba(arrayChars);
int count = SimbolosDatvla(arrayChars, ch);
DatvlilisDabruneba(count, ch);

void ElementebisDabruneba(char[] array)
{
    for (int i = 0;i < array.Length; i++)
    {
        char c = array[i];
        Console.WriteLine($"[{i}] = {c}");
    }
}

int SimbolosDatvla(char[] array, char c)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == c)
        {
            count++;
        }
    }

    return count;
}

void DatvlilisDabruneba(int count, char c)
{
    Console.WriteLine($"'{c}' shegxvda {count} jer");
}