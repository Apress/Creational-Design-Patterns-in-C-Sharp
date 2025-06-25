public class Car : IVehicle
{
    public string Run(int speed)
    {
        return $"{this} at {speed} mph";
    }
    public override string ToString()
    {
        return "car";
    }
}

