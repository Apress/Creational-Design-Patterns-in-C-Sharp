// The ElectricCarBuilder builds electric cars.

class ElectricCarBuilder : Builder
{
    private readonly Car _car;
    public ElectricCarBuilder()
    {
        _car = new("electric");
    }
    public override Builder SetMotor()
    {
        _car.Motor = "electric motors and batteries";
        _car.Add($"The {_car.Motor} is added.");
        return this;
    }

    public override Builder InsertWheels()
    {
        _car.Wheels = 4;
        _car.Add($"{_car.Wheels} wheels are added to the car.");
        return this;
    }
    public override Builder SetHeadlights()
    {
        _car.HeadLights = 2;
        _car.Add($"{_car.HeadLights} headlights are set.");
        return this;
    }

    // NOTE: The electric car does not need the exhaust emission system.
    // So, we do not need to override the base class method.

    // Retrieve the constructed car
    public override Car GetCar()
    {
        return _car;
    }
}
