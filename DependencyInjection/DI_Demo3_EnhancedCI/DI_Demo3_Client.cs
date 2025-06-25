//using System;

IVehicle vehicle = new Car();
Driver driver = new(vehicle);
driver.Drive(100);

vehicle = new Bus();
driver = new(vehicle);
driver.Drive(150);

