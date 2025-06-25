using static System.Console;

#region Approach-2: Can work in a multithreaded environment
class Captain
{
    readonly string status = "is not elected yet";
    private Captain()
    {
        status = "is ready for the coin toss.";
        WriteLine("One captain is elected for the team.");
    }
    private static readonly object _lock = new();
    private static Captain? _instance;
    public static Captain Instance
    {
        get
        {
            lock (_lock)
            {
                _instance ??= new();
            }
            return _instance;
        }
    }

    public string GetStatus() => status;

}
#endregion
