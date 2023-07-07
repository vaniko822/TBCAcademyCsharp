using System.Reflection;
using Task1;

Console.WriteLine("Choose Class - F1GrandPrixList or F1Teams");
Console.Write("Enter the name of the class you want to create: ");
var className = Console.ReadLine();

if(className == "F1GrandPrixList")
{
    var type = typeof(F1GrandPrixList);

    MethodInfo[] methods = type.GetMethods();

    F1GrandPrixList grandPrixList = new F1GrandPrixList();

    while (true)
    {
        GetMethods(methods, type);

        string methodName = Console.ReadLine();

        if(methodName == "Close")
        {
            break;
        }

        switch (methodName)
        {
            case "AddF1GrandPrix":
                Console.WriteLine("Enter grand prix name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter grand prix location: ");
                string location = Console.ReadLine();
                Console.WriteLine("Enter grand prix total laps: ");
                int totalLaps = int.Parse(Console.ReadLine());

                MethodInfo addF1GrandPrix = type.GetMethod(methodName);
                addF1GrandPrix.Invoke(grandPrixList, BindingFlags.Public | BindingFlags.Instance, null, new object?[] { name, location, totalLaps }, null);
                break;
            case "GetGrandPrixList":
                MethodInfo getGrandPrixList = type.GetMethod(methodName);
                getGrandPrixList.Invoke(grandPrixList, BindingFlags.Public | BindingFlags.Instance, null, new object?[] { }, null);
                break;
        }
    }
}
if (className == "F1Teams")
{
    var type = typeof(F1Teams);

    MethodInfo[] methods = type.GetMethods();

    F1Teams f1TeamList = new F1Teams();

    while (true)
    {
        GetMethods(methods, type);

        string methodName = Console.ReadLine();

        if (methodName == "Close")
        {
            break;
        }

        switch (methodName)
        {
            case "AddTeam":
                Console.WriteLine("Enter team name: ");
                string name = Console.ReadLine();

                MethodInfo addTeam = type.GetMethod(methodName);
                addTeam.Invoke(f1TeamList, BindingFlags.Public | BindingFlags.Instance, null, new object?[] { name }, null);
                break;
            case "ChooseTeam":
                Console.WriteLine("Enter team name: ");
                string teamName = Console.ReadLine();

                MethodInfo chooseTeam = type.GetMethod(methodName);
                chooseTeam.Invoke(f1TeamList, BindingFlags.Public | BindingFlags.Instance, null, new object?[] { teamName }, null);
                break;
            case "GetTeams":
                MethodInfo getTeams = type.GetMethod(methodName);
                getTeams.Invoke(f1TeamList, BindingFlags.Public | BindingFlags.Instance, null, new object?[] { }, null);
                break;
        }
    }
}

void GetMethods(MethodInfo[] methods, Type type)
{
    int i = 1;
    Console.WriteLine("Methods:");
    foreach (MethodInfo method in methods)
    {
        if (method.DeclaringType == type)
        {
            Console.WriteLine($"{i}) {method.Name}");
            i++;
        }
    }
    Console.WriteLine("Close");
}