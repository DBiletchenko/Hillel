using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal abstract class Vehicle
    {
        public int NumberOfWheels;
        private int _vehicleValue;
        private string _Manufacturer;
        private string _serialNumber;
        public abstract void Move();
        public virtual void Horn()
        {
            Console.WriteLine("Beep-beep");
        }


        internal string manufacturer
        {
            get
            {
                return _Manufacturer;
            }
        }
        internal string Serial
        {
            get
            {
                return _serialNumber;
            }
        }

        public int Value
        {
            get
            {
                return _vehicleValue;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Value of the vehicle can't be less or equal to 0");
                }
                else
                {
                    _vehicleValue = value;
                }
            }
        }


        public Vehicle()
        {

        }
        public Vehicle(int wheels, string manufacturer, string serialNum)
        {
            NumberOfWheels = wheels;
            _Manufacturer = manufacturer;
            _serialNumber = serialNum;
        }
    }
}


