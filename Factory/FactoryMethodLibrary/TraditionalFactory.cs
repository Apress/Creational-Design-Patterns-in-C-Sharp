//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using VehicleLibrary;

namespace FactoryMethodLibrary
{
    public class TraditionalFactory : VehicleFactory
    {
       protected override Vehicle? CreateVehicle(string type)
        {

            Vehicle? vehicle = null;
            if (type == "car")
            {
                vehicle = new TraditionalCar();
            }
            if (type == "motorcycle")
            {
                vehicle = new TraditionalMotorcycle();
            }           
            return vehicle;
        }
    }
}

