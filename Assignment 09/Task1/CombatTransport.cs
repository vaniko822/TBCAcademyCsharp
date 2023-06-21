using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class CombatTransport : Vehicle
    {
        private int _capacity;
        private bool _hasWeapon;
        private bool _hasArmor;

        public CombatTransport(string manufacturer, string model, int year, string color, int wheels, int capacity, bool hasWeapon, bool hasArmor)
            : base(manufacturer, model, year, color, wheels)
        {
            this._capacity = capacity;
            this._hasWeapon = hasWeapon;
            this._hasArmor = hasArmor;
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        public bool HasWeapon
        {
            get
            {
                return _hasWeapon;
            }
            set
            {
                _hasWeapon = value;
            }
        }

        public bool HasArmor
        {
            get
            {
                return _hasArmor;
            }
            set
            {
                _hasArmor = value;
            }
        }
    }

    public class Tank : CombatTransport
    {
        private static int wheels;
        private int _bulletCapacity;

        public Tank(string manufacturer, string model, int year, string color, int capacity, bool hasWeapon, bool hasArmor, int bulletCapacity)
            : base(manufacturer, model, year, color, wheels, capacity, hasWeapon, hasArmor)
        {
            this._bulletCapacity = bulletCapacity;
            base.Wheels = 0;
        }

        public int BulletCapacity
        {
            get
            {
                return _bulletCapacity;
            }
            set
            {
                _bulletCapacity = value;
            }
        }

        public void Shoot()
        {
            if (BulletCapacity > 0)
            {
                Console.WriteLine("Shot!");
                BulletCapacity--;
            }
            else
            {
                Console.WriteLine("Not Enough Bullet!");
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
                $"Capacity - {Capacity}" + "\n" +
                $"HasWeapon - {HasWeapon}" + "\n" +
                $"HasArmor - {HasArmor}" + "\n" +
                $"Bullet Capacity - {BulletCapacity}"
                );
        }
    }

    public class CombatAirCraft : CombatTransport
    {
        private static int wheels;
        private int _topFlightHeight;

        public CombatAirCraft(string manufacturer, string model, int year, string color, int capacity, bool hasWeapon, bool hasArmor, int topFlightHeight)
            : base(manufacturer, model, year, color, wheels, capacity, hasWeapon, hasArmor)
        {
            this._topFlightHeight = topFlightHeight;
            base.Wheels = 0;
        }

        public int TopFlightHeight
        {
            get
            {
                return _topFlightHeight;
            }
            set
            {
                _topFlightHeight = value;
            }
        }

        public void AircraftTopFlightHeight()
        {
            Console.WriteLine("Top Flight Height - " + TopFlightHeight + " On KM");
        }

        public override void VehicleInfo()
        {
            Console.WriteLine(
                $"Manufacturer - {Manufacturer}" + "\n" +
                $"Model - {Model}" + "\n" +
                $"Year - {Year}" + "\n" +
                $"Color - {Color}" + "\n" +
                $"Wheels - {Wheels}" + "\n" +
                $"Capacity - {Capacity}" + "\n" +
                $"HasWeapon - {HasWeapon}" + "\n" +
                $"HasArmor - {HasArmor}" + "\n" +
                $"Top Flight Height(KM) - {TopFlightHeight}"
                );
        }
    }
}
