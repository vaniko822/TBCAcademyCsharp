using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class PublicTransport : Vehicle
    {
        private string _vehicleType;
        private int _passangerCapacity;
        private double _travelFee;

        public PublicTransport(string manufacturer, string model, int year, string color, int wheels, string vehicleType, int passangerCapacity, double travelFee)
            : base(manufacturer, model, year, color, wheels)
        {
            this._vehicleType = vehicleType;
            this._passangerCapacity = passangerCapacity;
            this._travelFee = travelFee;
        }

        public string VehicleType
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                _vehicleType = value;
            }
        }

        public int PassangerCapacity
        {
            get
            {
                return _passangerCapacity;
            }
            set
            {
                _passangerCapacity = value;
            }
        }

        public double TravelFee
        {
            get
            {
                return _travelFee;
            }
            set
            {
                _travelFee = value;
            }
        }

        public abstract void OpenDoors();
        public abstract void CloseDoors();
    }

    public class Bus : PublicTransport
    {
        private static string vehicleType;
        private int _doors;

        public Bus(string manufacturer, string model, int year, string color, int wheels, int passangerCapacity, double travelFee, int doors) 
            : base(manufacturer, model, year, color, wheels, vehicleType, passangerCapacity, travelFee)
        {
            this._doors = doors;
            vehicleType = "Bus";
        }

        public int Doors
        {
            get
            {
                return _doors;
            }
            set
            {
                _doors = value;
            }
        }

        public override void CloseDoors()
        {
            Console.WriteLine("The bus doors closed!");
        }

        public override void OpenDoors()
        {
             Console.WriteLine("The bus doors opened!");
        }

        public override void VehicleInfo()
        {
            Console.WriteLine(
                $"Manufacturer - {Manufacturer}" + "\n" +
                $"Model - {Model}" + "\n" +
                $"Year - {Year}" + "\n" +
                $"Color - {Color}" + "\n" +
                $"Wheels - {Wheels}" + "\n" +
                $"Vehicle Type - {VehicleType}" + "\n" +
                $"PassengerCapacity - {PassangerCapacity}" + "\n" +
                $"Travel Fee -  {TravelFee}" + "\n" +
                $"Number Of Doors - {Doors}"
                );
        }
    }

    public class Subway : PublicTransport
    {
        private static string vehicleType;
        private static int wheels;
        private int _numberOfWagons;

        public Subway(string manufacturer, string model, int year, string color, int passangerCapacity, double travelFee, int numberOfWagons)
            : base(manufacturer, model, year, color, wheels, vehicleType, passangerCapacity, travelFee)
        {
            this._numberOfWagons = numberOfWagons;
            wheels = 0;
            vehicleType = "Subway";
        }

        public int NumberOfWagons
        {
            get
            {
                return _numberOfWagons;
            }
            set
            {
                _numberOfWagons = value;
            }
        }

        public override void CloseDoors()
        {
            Console.WriteLine("The subway doors closed!");
        }

        public override void OpenDoors()
        {
            Console.WriteLine("The subway doors opened!");
        }

        public override void VehicleInfo()
        {
            Console.WriteLine(
                $"Manufacturer - {Manufacturer}" + "\n" +
                $"Model - {Model}" + "\n" +
                $"Year - {Year}" + "\n" +
                $"Color - {Color}" + "\n" +
                $"Wheels - {Wheels}" + "\n" +
                $"Vehicle Type - {VehicleType}" + "\n" +
                $"PassengerCapacity - {PassangerCapacity}" + "\n" +
                $"Travel Fee - {TravelFee}" + "\n" +
                $"Number Of Wagons - {NumberOfWagons}"
                );
        }
    }
}
