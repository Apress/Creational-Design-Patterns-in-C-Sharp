using VehicleLibrary;
using static System.Console;

WriteLine("Understanding the need of factories.\n");

Vehicle? vehicle = CreateAndDisplayVehicle("car");
WriteLine($"The {vehicle} construction process is completed.");

WriteLine("-----------");

vehicle = CreateAndDisplayVehicle("motorcycle");
WriteLine($"The {vehicle} construction process is completed.");


static Vehicle? CreateAndDisplayVehicle(string type)
{
    Vehicle? vehicle = null;
    //if (type.Equals("car"))
    //{
    //    vehicle = new Car();
    //}
    if (type == "car")
    {
        vehicle = new Car();
    }
    if (type == "motorcycle")
    {
        vehicle = new Motorcycle();
    }
    vehicle?.Display();
    return vehicle;
}


