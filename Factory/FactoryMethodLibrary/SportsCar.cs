//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using VehicleLibrary;
using static System.Console;

namespace FactoryMethodLibrary
{
    internal class SportsCar : Vehicle
    {
        public SportsCar()
        {
            type = "sports car";
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