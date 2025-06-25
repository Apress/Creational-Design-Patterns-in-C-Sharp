using VehicleLibrary;
using SimpleFactoryLibrary;
using static System.Console;

WriteLine("Using the simple factory pattern.\n");

Vehicle? vehicle = CreateAndDisplayVehicle("car");
WriteLine($"The {vehicle} construction process is completed.");

WriteLine("-----------");

vehicle = CreateAndDisplayVehicle("motorcycle");
WriteLine($"The {vehicle} construction process is completed.");


static Vehicle? CreateAndDisplayVehicle(string type)
{
    Vehicle? vehicle = SimpleVehicleFactory.CreateVehicle(type);
    vehicle?.Display();
    return vehicle;
}

