using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class SportTransport : Vehicle
    {
        private string _carType;
        private int _topSpeed;

        public SportTransport(string manufacturer, string model, int year, string color, int wheels, string carType, int topSpeed)
            : base(manufacturer, model, year, color, wheels)
        {
            this._carType = carType;
            this._topSpeed = topSpeed;
        }

        public string CarType
        {
            get
            {
                return _carType;
            }
            set
            {
                _carType = value;
            }
        }

        public int TopSpeed
        {
            get
            {
                return _topSpeed;
            }
            set
            {
                _topSpeed = value;
            }
        }
    }

    public class F1Car : SportTransport
    {
        private static int wheels;
        private static string carType;
        private static int year;
        private string _team;
        private string _driver;
        private int _engineHorsePower;

        public F1Car(string manufacturer, string model, string color, int topSpeed, string team, string driver, int engineHorsePower) 
            : base(manufacturer, model, year, color, wheels, carType, topSpeed)
        {
            this._team = team;
            this._driver = driver;
            this._engineHorsePower = engineHorsePower;
            wheels = 4;
            carType = "Formula Car";
            year = 2023;
        }

        public string Team
        {
            get
            {
                return _team;
            }
            set
            {
                _team = value;
            }
        }
        public string Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }
        public int EngineHorsePower
        {
            get
            {
                return _engineHorsePower;
            }
            set
            {
                _engineHorsePower = value;
            }
        }

        public void ActivateDRS()
        {
            Console.WriteLine("DRS Activated!");
        }

        public void DeactivateDRS()
        {
            Console.WriteLine("DRS Deactivated!");
        }
        public override void VehicleInfo()
        {
            Console.WriteLine(
                $"Manufacturer - {Manufacturer}" + "\n" +
                $"Model - {Model}" + "\n" +
                $"Year - {Year}" + "\n" +
                $"Color - {Color}" + "\n" +
                $"Wheels - {Wheels}" + "\n" +
                $"Car Type - {CarType}" + "\n" +
                $"Top Speed - {TopSpeed}" + "\n" +
                $"Team - {Team}" + "\n" +
                $"Driver - {Driver}" + "\n" +
                $"Engine Horse Power - {EngineHorsePower}"
                );
        }
    }

    public class RallyCar : SportTransport
    {
        private static int year;
        private static int wheels;
        private static string carType;
        private double _carWeight;

        public RallyCar(string manufacturer, string model, string color, int topSpeed, double carWeight)
            : base(manufacturer, model, year, color, wheels, carType, topSpeed)
        {
            this._carWeight = carWeight;
            year = 2023;
            wheels = 4;
            carType = "Rally Car";
        }

        public double CarWeight
        {
            get
            {
                return _carWeight;
            }
            set
            {
                _carWeight = value;
            }
        }

        public void Race()
        {
            Console.WriteLine("The rally car is racing!");
        }

        public override void VehicleInfo()
        {
            Console.WriteLine(
                $"Manufacturer - {Manufacturer}" + "\n" +
                $"Model - {Model}" + "\n" +
                $"Year - {Year}" + "\n" +
                $"Color - {Color}" + "\n" +
                $"Wheels - {Wheels}" + "\n" +
                $"Car Type - {CarType}" + "\n" +
                $"Top Speed - {TopSpeed}" + "\n" +
                $"Car Weight - {CarWeight}"
                );
        }
    }
}
