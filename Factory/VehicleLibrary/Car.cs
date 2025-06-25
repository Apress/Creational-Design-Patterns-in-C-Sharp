//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using static System.Console;

namespace VehicleLibrary
{
    public class Car : Vehicle
    {      
        public Car()
        {
            type = "car";
        }
        public override void Display()
        {
            WriteLine($"A {this} is created.");            
        }
        public override string ToString()
        {
            return type;
        }
    }
}
