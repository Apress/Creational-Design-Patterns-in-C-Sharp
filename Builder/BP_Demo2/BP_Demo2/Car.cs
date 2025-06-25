using static System.Console;

// The Car class represents the "Product" 

#region The code segment that uses a primary constructor
class Car(string type)
{
    /*
	 * You can use any data structure that you prefer. 
	 * I have used LinkedList<String> in this case.
	 */

    private readonly LinkedList<string> _parts = new();

    public int HeadLights { get; set; }
    public string Motor { get; set; }
    public  int Wheels { get; set; }
    // By default, the exhaust emission system is not needed for an electric car
    public string ExhaustEmissions { get; set; } = "not set";
    public void Add(string part)
    {
        // Adding parts
        _parts.AddLast(part);
    }

    public void ShowProduct()
    {
        WriteLine($"The {type} car construction sequence:");
        foreach (string part in _parts)
            WriteLine(part);
    }
}
#endregion


#region The code without a primary constructor
//class Car
//{
//    /*
//	 * You can use any data structure that you prefer. 
//	 * I have used LinkedList<String> in this case.
//	 */

//    private LinkedList<string> _parts;
//    private string _type;
//    public Car(string type)
//    {
//        _type = type;
//        _parts = new LinkedList<string>();
//    }

//    public int HeadLights { get; set; }
//    public string Motor { get; set; }
//    public int Wheels { get; set; }
//    // By default, the exhaust emission system is not needed for an electric car
//    public string ExhaustEmissions { get; set; } = "not set";
//    public void Add(string part)
//    {
//        // Adding parts
//        _parts.AddLast(part);
//    }

//    public void ShowProduct()
//    {
//        WriteLine($"The {_type} car construction sequence:");
//        foreach (string part in _parts)
//            WriteLine(part);
//    }
//}
#endregion
