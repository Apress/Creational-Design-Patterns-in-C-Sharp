// Car.cs
abstract class Car
{
    protected string company;
    protected Model model;
    public double price;
    public Car()
    {
        company = "Not set";
        model = new Model();
        price = 0;
    }
    public abstract void UpdateCar(string modelName, string color, double increasedPrice = 0);  
    public abstract Car CloneCar();
}

