abstract class Builder
{
    public abstract void SetMotor();
    public abstract void InsertWheels();
    public abstract void SetHeadlights();
    // The exhauset emissions system is needed needed for regular cars
    public virtual void AddExhaustSystem() { }
    // To retrieve the constructed product. 
    public abstract Car GetCar();
}
