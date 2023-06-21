using Microsoft.VisualBasic.FileIO;
using System.Threading.Tasks;
using Task1;

Console.WriteLine("Choose Transport Type:" + "\n" +
    "1. Combat Transport" + "\n" +
    "2. Consumer Transport" + "\n" +
    "3. Public Transport" + "\n" +
    "4. Sport Transport");

int chooseTransportType = int.Parse(Console.ReadLine());

Console.WriteLine("Choose Special Option: ");
switch (chooseTransportType)
{
    case 1:
        foreach(var option in Enum.GetValues(typeof(CombatTransportOptions)))
        {
            Console.WriteLine($"{(int)option + 1}. " + option);
        }
        int chooseCombatTransport = int.Parse(Console.ReadLine());
        switch (chooseCombatTransport)
        {
            case 1:
                CreateCombatTransport("Tank");
                break;
            case 2:
                CreateCombatTransport("CombatAirCraft");
                break;
        }
        break;
    case 2:
        foreach (var option in Enum.GetValues(typeof(ConsumerTransportOptions)))
        {
            Console.WriteLine($"{(int)option + 1}. " + option);
        }
        int chooseConsumerTransport = int.Parse(Console.ReadLine());
        switch (chooseConsumerTransport)
        {
            case 1:
                CreateConsumerTransport("Sedan");
                break;
            case 2:
                CreateConsumerTransport("Jeep");
                break;
        }
        break;
    case 3:
        foreach (var option in Enum.GetValues(typeof(PublicTransportOptions)))
        {
            Console.WriteLine($"{(int)option + 1}. " + option);
        }
        int choosePublicTransport = int.Parse(Console.ReadLine());
        switch (choosePublicTransport)
        {
            case 1:
                CreatePublicTransport("Bus");
                break;
            case 2:
                CreatePublicTransport("Subway");
                break;
        }
        break;
    case 4:
        foreach (var option in Enum.GetValues(typeof(SportTransportOptions)))
        {
            Console.WriteLine($"{(int)option + 1}. " + option);
        }
        int chooseSportTransport = int.Parse(Console.ReadLine());
        switch (chooseSportTransport)
        {
            case 1:
                CreateSportTransport("F1");
                break;
            case 2:
                CreateSportTransport("Rally");
                break;
        }
        break;
}

void CreateCombatTransport(string specialOption)
{
    Console.WriteLine("Manufacturer: ");
    string manufacturer = Console.ReadLine();
    Console.WriteLine("Model: ");
    string model = Console.ReadLine();
    Console.WriteLine("Year: ");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("Color: ");
    foreach (var color in Enum.GetValues(typeof(Colors)))
    {
        Console.WriteLine(color);
    }
    string chooseColor = Console.ReadLine();
    Console.WriteLine("Capacity: ");
    int capacity = int.Parse(Console.ReadLine());
    Console.WriteLine("Has Weapon: ");
    bool hasWeapon = bool.Parse(Console.ReadLine());
    Console.WriteLine("Has Armor: ");
    bool hasArmor = bool.Parse(Console.ReadLine());

    if (specialOption == "Tank")
    {
        Console.WriteLine("Bullet Capacity: ");
        int bulletCapacity = int.Parse(Console.ReadLine());
        Tank tank = new Tank(manufacturer, model, year, chooseColor, capacity, hasWeapon, hasArmor, bulletCapacity);

        tank.VehicleInfo();

        tank.Shoot();
    }
    else if(specialOption == "CombatAirCraft")
    {
        Console.WriteLine("Top Flight Height(KM): ");
        int topFlightHeight = int.Parse(Console.ReadLine());
        CombatAirCraft combatAirCraft = new CombatAirCraft(manufacturer, model, year, chooseColor, capacity, hasWeapon, hasArmor, topFlightHeight);
        
        combatAirCraft.VehicleInfo();

        combatAirCraft.AircraftTopFlightHeight();
    }
}

void CreateConsumerTransport(string specialOption)
{
    Console.WriteLine("Manufacturer: ");
    string manufacturer = Console.ReadLine();
    Console.WriteLine("Model: ");
    string model = Console.ReadLine();
    Console.WriteLine("Year: ");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("Color: ");
    foreach (var color in Enum.GetValues(typeof(Colors)))
    {
        Console.WriteLine(color);
    }
    string chooseColor = Console.ReadLine();
    Console.WriteLine("Wheels: ");
    int wheels = int.Parse(Console.ReadLine());
    Console.WriteLine("Transmission: ");
    string transmission = Console.ReadLine();
    Console.WriteLine("PassengerCapacity: ");
    int passengerCapacity = int.Parse(Console.ReadLine());
    Console.WriteLine("Fuel Type: ");
    string fuelType = Console.ReadLine();


    if (specialOption == "Sedan")
    {
        Console.WriteLine("Fuel Capacity: ");
        int fuelCapacity = int.Parse(Console.ReadLine());
        Sedan sedan = new Sedan(manufacturer, model, year, chooseColor, wheels, transmission, passengerCapacity, fuelType, fuelCapacity);

        sedan.VehicleInfo();

        Console.WriteLine("Fill fuel: ");
        int fuel = int.Parse(Console.ReadLine());
        sedan.FillFuel(fuel);

    }
    else if (specialOption == "Jeep")
    {
        Console.WriteLine("Is 4x4: ");
        bool is4x4 = bool.Parse(Console.ReadLine());
        Jeep jeep = new Jeep(manufacturer, model, year, chooseColor, wheels, transmission, passengerCapacity, fuelType, is4x4);

        jeep.VehicleInfo();

        jeep.SwitchTo4x4();
    }
}

void CreatePublicTransport(string specialOption)
{
    Console.WriteLine("Manufacturer: ");
    string manufacturer = Console.ReadLine();
    Console.WriteLine("Model: ");
    string model = Console.ReadLine();
    Console.WriteLine("Year: ");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("Color: ");
    foreach (var color in Enum.GetValues(typeof(Colors)))
    {
        Console.WriteLine(color);
    }
    string chooseColor = Console.ReadLine();
    Console.WriteLine("Passenger Capacity: ");
    int passengerCapacity = int.Parse(Console.ReadLine());
    Console.WriteLine("Travel Fee: ");
    double travelFee = double.Parse(Console.ReadLine());

    if (specialOption == "Bus")
    {
        Console.WriteLine("Wheels: ");
        int wheels = int.Parse(Console.ReadLine());
        Console.WriteLine("Number of doors: ");
        int doors = int.Parse(Console.ReadLine());
        Bus bus = new Bus(manufacturer, model, year, chooseColor, wheels, passengerCapacity, travelFee, doors);

        bus.VehicleInfo();

        bus.OpenDoors();
        bus.CloseDoors();

    }
    else if (specialOption == "Subway")
    {
        Console.WriteLine("Number of wagons: ");
        int numberOfWagons = int.Parse(Console.ReadLine());
        Subway subway = new Subway(manufacturer, model, year, chooseColor, passengerCapacity, travelFee, numberOfWagons);

        subway.VehicleInfo();

        subway.OpenDoors();
        subway.CloseDoors();
    }
}

void CreateSportTransport(string specialOption)
{
    Console.WriteLine("Manufacturer: ");
    string manufacturer = Console.ReadLine();
    Console.WriteLine("Model: ");
    string model = Console.ReadLine();
    Console.WriteLine("Color: ");
    foreach (var color in Enum.GetValues(typeof(Colors)))
    {
        Console.WriteLine(color);
    }
    string chooseColor = Console.ReadLine();
    Console.WriteLine("Top Speed: ");
    int topSpeed = int.Parse(Console.ReadLine());

    if (specialOption == "F1")
    {
        Console.WriteLine("Team: ");
        string team = Console.ReadLine();
        Console.WriteLine("Driver: ");
        string driver = Console.ReadLine();
        Console.WriteLine("Engine Horse Power: ");
        int engineHorsePower = int.Parse(Console.ReadLine());
        F1Car f1 = new F1Car(manufacturer, model, chooseColor, topSpeed, team, driver, engineHorsePower);

        f1.VehicleInfo();

        f1.ActivateDRS();
        f1.DeactivateDRS();

    }
    else if (specialOption == "Rally")
    {
        Console.WriteLine("Car Weight: ");
        int carWeight = int.Parse(Console.ReadLine());
        RallyCar rallyCar = new RallyCar(manufacturer, model, chooseColor, topSpeed, carWeight);

        rallyCar.VehicleInfo();

        rallyCar.Race();
    }
}