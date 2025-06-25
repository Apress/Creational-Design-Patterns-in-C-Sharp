using static System.Console;
class Driver : IVehicleUser
{
   private  IVehicle _vehicle; 
    public void SetVehicle(IVehicle vehicle)
    {
       _vehicle = vehicle;
    }
    public void Drive(int speed)
    {
        WriteLine($"The driver can drive a {_vehicle.Run(speed)}");
    }
}

