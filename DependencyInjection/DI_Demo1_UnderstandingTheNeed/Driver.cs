using static System.Console;
class Driver
{
    private readonly Car _car;
    public Driver()
    {
        _car = new Car();
    }
    public void Drive(int speed)
    {
        WriteLine($"The driver can drive a {_car.Run(speed)}");
    }
}

