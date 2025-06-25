//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using VehicleLibrary;

namespace FactoryMethodLibrary
{
    public class SportsFactory : VehicleFactory
    {
        protected override Vehicle? CreateVehicle(string type)
        {
            Vehicle? vehicle = null;
            if (type == "car")
            {
                vehicle = new SportsCar();
            }
            if (type == "motorcycle")
            {
                vehicle = new SportsMotorcycle();
            }
            return vehicle;
        }
    }

}