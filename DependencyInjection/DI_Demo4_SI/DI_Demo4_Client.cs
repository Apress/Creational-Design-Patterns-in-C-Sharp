IVehicle vehicle = new Car();
Driver driver = new()
{
    Vehicle = vehicle
    //Vehicle = null // testing for the null scenario
};
driver.Drive(100);

// Creating a new vehicle 
vehicle = new Bus();
// Letting the driver drive the new vehicle( i.e. a bus)
driver.Vehicle = vehicle;
driver.Drive(150);
