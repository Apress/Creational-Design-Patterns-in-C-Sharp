using static System.Console;

#region Approach-4: Lazy Initialization
sealed class Captain
{
    readonly string status = "is not elected yet";
    private Captain()
    { 
        status = "is ready for the coin toss.";
        WriteLine("One captain is elected for the team.");
    }
    //private static readonly Captain _instance = new();
    private static readonly Lazy<Captain> _instance = new(
        () => new Captain()
        );

    public static Captain Instance
    {
        //get { return _instance; }
        get { return _instance.Value; }
    }

    public string GetStatus() => status;
}
#endregion
