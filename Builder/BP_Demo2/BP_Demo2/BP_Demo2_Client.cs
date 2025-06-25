using static System.Console;
WriteLine("*** Builder Pattern Demonstration 2***");

// Making a traditional car
// The director performs the following steps before returning the constructed product:
// Set motor-> Insert wheels->Set headlights->Add exhaust system
Builder builder = new TraditionalCarBuilder();
Car car = builder.SetMotor()
    .InsertWheels()
    .SetHeadlights()
     .AddExhaustSystem()
    .GetCar();
car.ShowProduct();

// Also works (removing the usage of car variable and increasing the chain):
//builder.SetMotor()
//    .InsertWheels()
//    .SetHeadlights()
//     .AddExhaustSystem()
//    .GetCar()
//    .ShowProduct();

WriteLine("============");
// Making an electric car now.")
// The director follows a different sequence and return the constructed product:
// Set motor->Set headlights-> Insert wheels.

builder = new ElectricCarBuilder();
car = builder.SetMotor()
    .SetHeadlights()
    .InsertWheels()
    // .AddExhaustSystem ()  // Not required for an electric car
    .GetCar();
car.ShowProduct();

// Also works (removing the usage of car variable and increasing the chain):
//builder.SetMotor()
//    .SetHeadlights()
//    .InsertWheels()
//    // .AddExhaustSystem ()  // Not required for an electric car
//    .GetCar()
//    .ShowProduct();
