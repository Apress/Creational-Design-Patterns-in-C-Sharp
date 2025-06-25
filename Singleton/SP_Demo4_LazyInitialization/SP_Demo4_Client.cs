using static System.Console;

//Captain captain = new();  // Inaccessible

//Captain captain = Captain.Instance;
//WriteLine($"The captain {captain.GetStatus()}");
//Captain captain2 = Captain.Instance;
//WriteLine($"The captain {captain2.GetStatus()}");


// The following code block will work here if the constructor is public
//Lazy<Captain> captain3 = new(
//        () => new Captain()  
//        );
//WriteLine("Here");  // captain3.Value is still null at this point

Captain captain;
var task1 = Task.Run(
    () =>
    {
        captain = Captain.Instance;
        WriteLine($"The captain {captain.GetStatus()}");
    }
    );

var task2 = Task.Run(
    () =>
    {
        captain = Captain.Instance;
        WriteLine($"The captain {captain.GetStatus()}");
    }
    );
Task.WaitAll(task1, task2);




