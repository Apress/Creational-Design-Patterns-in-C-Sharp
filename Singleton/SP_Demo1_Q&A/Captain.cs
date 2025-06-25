using static System.Console;

#region Approach-1: Not suitable for multithreading
//sealed class Captain
class Captain
{
    readonly string status = "is not elected.";
    private Captain()
    {
        status = "is ready for the coin toss.";
        WriteLine("One captain is elected for the team.");
    }

    private static Captain? _instance;
    public static Captain Instance
    {
        get
        {
            //if (_instance == null)
            //{
            //    _instance = new();
            //}
            // Or, use a compound assignment
            _instance ??= new();
            return _instance;
        }
    }

    public string GetStatus() => status;

    #region This code block is added to discuss the Q&A
    public class NestedDerived : Captain
    {
        // Some other code, if any
    }
    #endregion
}
#endregion
