using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Car : Vehicle
    {
        
        public override void Move()
        {
            Console.WriteLine("You've rode a car");
        }
    }
}
