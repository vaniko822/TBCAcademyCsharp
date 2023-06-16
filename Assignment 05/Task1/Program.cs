Console.WriteLine("Sheiyvanet masivis zoma: ");
int arraySize = int.Parse(Console.ReadLine());

int[] arrayNumbers = new int[arraySize];

Console.WriteLine("Sheiyvanet masivis elementebi: ");
for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"[{i}]");
    int arrayNumber = int.Parse(Console.ReadLine());
    arrayNumbers[i] = arrayNumber;
}

Console.WriteLine("Sheiyvanet index: ");
int index = int.Parse(Console.ReadLine());

ElementisCifrebisJamisGamotvla(arrayNumbers, index);

void ElementisCifrebisJamisGamotvla(int[] array, int index)
{
    int sum = 0;
    int number = arrayNumbers[index];

    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }

    Console.WriteLine($"Elementis cifris jami: {sum}");
}


/* es meore variantia ubralod uaryofiti tu sheiyvana imas ver itvlis.
 *  mindoda gameketebina stringshi gadameyvana da mere charebit gadametarebina
 *  cikli da gadameyvana es charebi intshi isev da dametvala.
 */
//void ElemetisCifrebisJamisGamotvla2(int[] array, int index)
//{
//    if(index >= 0 && index < array.Length)
//    {
//        int number = arrayNumbers[index];
//        string numberToString = Convert.ToString(number);
//        int sum = 0;

//        for(int i = 0; i < numberToString.Length; i++)
//        {
//            char c = numberToString[i];
//            string s = c.ToString();
//            int numberToInt = int.Parse(s);
//            sum += numberToInt;
//        }
//        Console.WriteLine($"Elementis cifris jami: {sum}");
//    }
//    else
//    {
//        Console.WriteLine("Indexi naklebia 0ze an metia masivis zomaze");
//    }
//}