using static System.Console;

#region Approach-3: Concise implementation
sealed class Captain
{
    readonly string status = "is not elected yet";
    private Captain()
    {
        status = "is ready for the coin toss.";
        WriteLine("One captain is elected for the team.");
    }
    private static readonly Captain _instance = new();
    public static Captain Instance
    {
        get { return _instance; }
    }

    public string GetStatus() => status;

    #region To discuss the problem of this approach
    public static int Flag = 2;
    #endregion

}
#endregion