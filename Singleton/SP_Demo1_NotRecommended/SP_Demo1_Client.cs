using static System.Console;

Captain captain1 = Captain.Instance;
WriteLine($"The captain {captain1.GetStatus()}");
Captain captain2 = Captain.Instance;
WriteLine($"The captain {captain2.GetStatus()}");

//Captain captain = new();  // Inaccessible
//class Derived : Captain { } // Error


#region Discussing the problem in a multithreaded environment

//Captain captain;
//var task1 = Task.Run(
//    () =>
//    {
//        captain = Captain.Instance;
//        WriteLine($"The captain {captain.GetStatus()}");
//    }
//    );

//var task2 = Task.Run(
//    () =>
//    {
//        captain = Captain.Instance;
//        WriteLine($"The captain {captain.GetStatus()}");
//    }
//    );
//Task.WaitAll(task1, task2);
#endregion