//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using VehicleLibrary;

namespace SimpleFactoryLibrary
{
    static public class SimpleVehicleFactory
    {
        public static Vehicle? CreateVehicle(string type)
        {
            Vehicle? vehicle = null;           
            if (type == "car")
            {
                vehicle = new Car();
            }
            if (type == "motorcycle")
            {
                vehicle = new Motorcycle();
            }
            return vehicle;
        }
    }
}

