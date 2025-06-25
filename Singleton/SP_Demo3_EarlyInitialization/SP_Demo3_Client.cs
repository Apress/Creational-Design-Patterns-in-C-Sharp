using static System.Console;


//Captain captain = new();  // Inaccessible

//Captain captain = Captain.Instance;
//WriteLine($"The captain is {captain.GetStatus()}");
//Captain captain2 = Captain.Instance;
//WriteLine($"The captain is {captain2.GetStatus()}");

Captain captain;
var task1 = Task.Run(
    () =>
    {
        captain = Captain.Instance;
        WriteLine($"The captain is {captain.GetStatus()}");
    }
    );

var task2 = Task.Run(
    () =>
    {
        captain = Captain.Instance;
        WriteLine($"The captain is {captain.GetStatus()}");
    }
    );
Task.WaitAll(task1, task2);

//#region Discussing the problem of Approach-3
//WriteLine(Captain.Flag);
//#endregion








