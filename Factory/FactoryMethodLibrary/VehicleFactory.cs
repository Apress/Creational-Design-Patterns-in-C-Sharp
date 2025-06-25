//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using VehicleLibrary;

namespace FactoryMethodLibrary
{
    public abstract class VehicleFactory
    {
        public Vehicle? CreateAndDisplayVehicle(string type)
        {
            Vehicle? vehicle;
            vehicle = CreateVehicle(type);
            vehicle?.Display();
            return vehicle;
        }

        // This is the "factory method". Notice that I defer the
        // instantiation process to the subclasses.
        protected abstract Vehicle? CreateVehicle(string type);
    }   
}
