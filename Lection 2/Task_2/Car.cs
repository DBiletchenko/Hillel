using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Car : Vehicle
    {
        public int Mileage;

        public override void Move()
        {
            Console.WriteLine("You've rode a car");
        }
        public override void Horn()
        {
            Console.WriteLine("Honk-honk");
        }

        public Car()
        {
            Console.WriteLine("You have bought a car");
        }
        public Car(int wheels, string manufacturer, string serialNum) : base(wheels, manufacturer, serialNum)
        {

        }
    }
}
