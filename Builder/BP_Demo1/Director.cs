using static System.Console;

// The director directs the steps to make the product (car).
class Director
{
    // The director performs the steps in the followings sequence and returns the constructed product:
    // Set motor> Insert wheels->Set headlights->Add exhaust system(if applicable)
    public Car Instruct(Builder builder)
    {
        builder.SetMotor();
        builder.InsertWheels();
        builder.SetHeadlights();
        builder.AddExhaustSystem();
        return builder.GetCar();
    }
}