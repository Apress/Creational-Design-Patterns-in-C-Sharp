using static System.Console;

WriteLine("*** Builder Pattern Demonstration. * **");

Director director = new();

// Making a traditional car
Builder builder = new TraditionalCarBuilder();
Car car = director.Instruct(builder);
car.ShowProduct();

WriteLine("============");
// Making an electric car now.")
builder = new ElectricCarBuilder();
car = director.Instruct(builder);
car.ShowProduct();












