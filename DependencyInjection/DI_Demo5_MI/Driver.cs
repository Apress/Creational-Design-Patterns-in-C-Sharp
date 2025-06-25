using static System.Console;

class Driver
{
    public void Drive(IVehicle vehicle,int speed)
    {
        WriteLine($"The driver can drive a {vehicle.Run(speed)}");             
    }
}

