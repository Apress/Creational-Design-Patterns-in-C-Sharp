//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using static System.Console;
using VehicleLibrary;

namespace FactoryMethodLibrary
{
    internal class TraditionalCar : Vehicle
    {
        public TraditionalCar()
        {
           type = "traditional car";
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