using static System.Console;

WriteLine("***Prototype Pattern Demo***\n");
// Getting a default Ford car
Car initialCar = new Ford();
WriteLine("The initial car details:");
WriteLine(initialCar);
WriteLine("Increasing the price by 2000 and displaying its details:");
initialCar.price += 2000;
WriteLine(initialCar);

WriteLine("Getting another Ford car with some default settings by cloning.");
Car clonedCar =(Ford) initialCar.CloneCar();
WriteLine("The cloned car details:");
WriteLine(clonedCar);
WriteLine("============================");

#region Discussing the advantage of deep copy
WriteLine("Changing the model, color, and price of the cloned car.");
clonedCar.UpdateCar("Ranger", "Blue", 10000);
WriteLine("Here are the cloned car details:");
WriteLine(clonedCar);
WriteLine("Verifying the initial car details as well.");
WriteLine(initialCar);
#endregion

WriteLine("============================");
WriteLine("Changing the model, color, and price of the initial car now.");
initialCar.UpdateCar("F-150", "Red", 20000);
WriteLine("After these changes, the initial car details:");
WriteLine(initialCar);
WriteLine("Verifying the cloned car details as well.");
WriteLine(clonedCar);












