// The TraditionalCarBuilder builds traditional cars.

class TraditionalCarBuilder : Builder
{
    private readonly Car _car;
    public TraditionalCarBuilder()
    {
        _car = new("traditional");
    }
    public override void SetMotor()
    {
        _car.Motor = "internal combustion engine (fueled by diesel)";
        _car.Add($"The {_car.Motor} is added.");
    }

    public override void InsertWheels()
    {
        _car.Wheels = 6;
       _car.Add($"{_car.Wheels} wheels are added to the car.");
    }
    public override void SetHeadlights()
    {
        _car.HeadLights = 4;
        _car.Add($"{_car.HeadLights} headlights are set.");
    }
    // NOTE: The traditional car needs to have an exhaust emission system.
    // So, we need to override the base class method.
    public override void AddExhaustSystem()
    {
        _car.ExhaustEmissions = "set";
        _car.Add($"An exhaust emissions system is {_car.ExhaustEmissions}.");
    }

    // Retrieve the constructed car
    public override Car GetCar()
    {
        return _car;
    }
}