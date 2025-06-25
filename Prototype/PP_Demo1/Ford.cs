class Ford : Car
{
    public Ford()
    {
        // Setting a default Ford car        
        company = "Ford";
        model = new Model("Maverick", "Silver");
        price = 30000;
    }
   public override void UpdateCar(string modelName, string color, double increasedPrice = 0)
    {
        model.modelName = modelName;
        model.color = color;
        price += increasedPrice;
    }
    #region Applying the deep copy mechanism
    public override Car CloneCar()
    {
        // First, making a shallow copy
        Ford fordClone = (Ford)MemberwiseClone();
        // Resetting the model info (this step is essential for the deep copy)
        fordClone.model = new Model();
        // Setting a base price for the Ford car as well
        fordClone.price = 25000;
        return fordClone;
    }
    #endregion  
    public override string ToString()
    {
        return $"Company: {company}, Model: {model}, Price: ${price} \n";
    }
}

