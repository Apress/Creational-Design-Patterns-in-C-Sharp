// The TraditionalCarBuilder builds traditional cars.

class TraditionalCarBuilder : Builder
{
    private readonly Car _car;
    public TraditionalCarBuilder()
    {
        _car = new("traditional");
    }
    public override Builder SetMotor()
    {
        _car.Motor = "internal combustion engine (fueled by diesel)";
        _car.Add($"The {_car.Motor} is added.");
        return this;
    }

    public override Builder InsertWheels()
    {
        _car.Wheels = 6;
       _car.Add($"{_car.Wheels} wheels are added to the car.");
        return this;
    }
    public override Builder SetHeadlights()
    {
        _car.HeadLights = 4;
        _car.Add($"{_car.HeadLights} headlights are set.");
        return this;
    }
    // NOTE: The traditional car needs to have an exhaust emission system.
    // So, we need to override the base class method.
    public override Builder AddExhaustSystem()
    {
        _car.ExhaustEmissions = "set";
        _car.Add($"An exhaust emissions system is {_car.ExhaustEmissions}.");
        return this;
    }

    // Retrieve the constructed car
    public override Car GetCar()
    {
        return _car;
    }
}