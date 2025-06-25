using static System.Console;
class Driver(IVehicle vehicle)
{
    private readonly IVehicle _vehicle = vehicle;
    public void Drive(int speed)
    {
        WriteLine($"The driver can drive a {_vehicle.Run(speed)}");
    }
}

