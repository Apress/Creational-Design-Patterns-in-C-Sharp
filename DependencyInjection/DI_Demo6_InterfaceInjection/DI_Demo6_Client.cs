IVehicle vehicle = new Car();
IVehicleUser driver = new Driver();
driver.SetVehicle(vehicle);
// Let the driver drive a car
driver.Drive(100);

// Creating a new vehicle 
vehicle = new Bus();
// Letting the driver drive the new vehicle( i.e. a bus)
driver.Drive(150);
