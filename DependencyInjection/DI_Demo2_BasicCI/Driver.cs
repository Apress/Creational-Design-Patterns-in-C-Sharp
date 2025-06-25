using static System.Console;
//class Driver(Car car)
//{
//    private readonly Car _car = car; // Injecting the car
//    public void Drive(int speed)
//    {
//        WriteLine($"The driver can drive a {_car.Run(speed)}");
//    }
//}
#region Without using primary constructor
class Driver
{
    private readonly Car _car;
    public Driver(Car car)
    {
        _car = car; // Injecting the car
    }
    public void Drive(int speed)
    {
        WriteLine($"The driver can drive a {_car.Run(speed)}");
    }
}

#endregion
