using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Vehicle
    {
        private string _manufacturer;
        private string _model;
        private int _year;
        private string _color;
        private int _wheels;

        public Vehicle(string manufacturer, string model, int year, string color, int wheels)
        {
            this._manufacturer = manufacturer;
            this._model = model;
            this._year = year;
            this._color = color;
            this._wheels = wheels;
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                _manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public int Wheels
        {
            get
            {
                return _wheels;
            }
            set
            {
                _wheels = value;
            }
        }

        public void Start()
        {
            Console.WriteLine("The vehicle has started.");
        }

        public void Accelerate()
        {
            Console.WriteLine("The vehicle is accelerating.");
        }

        public void Brake()
        {
            Console.WriteLine("The vehicle is braking.");
        }

        public abstract void VehicleInfo();
    }
}
