using static System.Console;

class Driver
{
    // Using an auto property and making it required
    public required IVehicle Vehicle { get; set; }
    public void Drive(int speed)
    {     
        WriteLine($"The driver can drive a {Vehicle.Run(speed)}");
        //WriteLine($"The driver can drive a {Vehicle?.Run(speed)}");
    }
}

