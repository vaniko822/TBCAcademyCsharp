using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class ConsumerTransport : Vehicle
    {
        private string _transmission;
        private int _passengerCapacity;
        private string _fuelType;

        public ConsumerTransport(string manufacturer, string model, int year, string color, int wheels, string transmission, int passengerCapacity, string fuelType)
            : base(manufacturer, model, year, color, wheels)
        {
            this._transmission = transmission;
            this._passengerCapacity = passengerCapacity;
            this._fuelType = fuelType;
        }

        public string Transmission
        {
            get
            {
                return _transmission;
            }
            set
            {
                _transmission = value;
            }
        }

        public int PassengerCapacity
        {
            get
            {
                return _passengerCapacity;
            }
            set
            {
                _passengerCapacity = value;
            }
        }

        public string FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                _fuelType = value;
            }
        }
    }

    public class Sedan : ConsumerTransport
    {
        private int _fuelCapacity;

        public Sedan(string manufacturer, string model, int year, string color, int wheels, string transmission, int passengerCapacity, string fuelType, int fuelCapacity)
            : base(manufacturer, model, year, color, wheels, transmission, passengerCapacity, fuelType)
        {
            this._fuelCapacity = fuelCapacity;
        }

        public int FuelCapacity
        {
            get
            {
                return _fuelCapacity;
            }
            set
            {
                _fuelCapacity = value;
            }
        }

        public void FillFuel(int fuel)
        {
            if (fuel >= 0 || fuel <= FuelCapacity)
            {
                Console.WriteLine("Fuel was filled!");
            }
            else
            {
                Console.WriteLine("Not Enough Fuel Capacity!");
            }
        }
        public override void VehicleInfo()
        {
            Console.WriteLine(
                $"Manufacturer - {Manufacturer}" + "\n" +
                $"Model - {Model}" + "\n" +
                $"Year - {Year}" + "\n" +
                $"Color - {Color}" + "\n" +
                $"Wheels - {Wheels}" + "\n" +
                $"Transmission - {Transmission}" + "\n" +
                $"PassengerCapacity - {PassengerCapacity}" + "\n" +
                $"FuelType -  {FuelType}"
                );
        }
    }

    public class Jeep : ConsumerTransport
    {
        private bool _is4x4;

        public Jeep(string manufacturer, string model, int year, string color, int wheels, string transmission, int passengerCapacity, string fuelType, bool is4x4)
            : base(manufacturer, model, year, color, wheels, transmission, passengerCapacity, fuelType)
        {
            this._is4x4 = is4x4;
        }

        public bool Is4x4
        {
            get
            {
                return _is4x4;
            }
            set
            {
                _is4x4 = value;
            }
        }

        public void SwitchTo4x4()
        {
            Console.WriteLine("Switched 4x4!");
        }

        public override void VehicleInfo()
        {
            Console.WriteLine(
                $"Manufacturer - {Manufacturer}" + "\n" +
                $"Model - {Model}" + "\n" +
                $"Year - {Year}" + "\n" +
                $"Color - {Color}" + "\n" +
                $"Wheels - {Wheels}" + "\n" +
                $"Transmission - {Transmission}" + "\n" +
                $"PassengerCapacity - {PassengerCapacity}" + "\n" +
                $"FuelType -  {FuelType}"
                );
        }
    }
}
