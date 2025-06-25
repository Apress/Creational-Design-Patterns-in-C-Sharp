using static System.Console;
using FactoryMethodLibrary;
using VehicleLibrary;

WriteLine("The Factory Method pattern demonstration.\n");

VehicleFactory factory;

factory = new SportsFactory();
Vehicle? vehicle = factory.CreateAndDisplayVehicle("car");
WriteLine($"The {vehicle} construction process is completed.");
WriteLine("-----------");
vehicle = factory.CreateAndDisplayVehicle("motorcycle");
WriteLine($"The {vehicle} construction process is completed.");


WriteLine("\n====================");

factory = new TraditionalFactory();
vehicle=factory.CreateAndDisplayVehicle("car");
WriteLine($"The {vehicle} construction process is completed.");
WriteLine("-----------");
vehicle=factory.CreateAndDisplayVehicle("motorcycle");
WriteLine($"The {vehicle} construction process is completed.");

