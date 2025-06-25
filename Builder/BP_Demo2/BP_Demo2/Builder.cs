abstract class Builder
{
    public abstract Builder SetMotor();
    public abstract Builder InsertWheels();
    public abstract Builder SetHeadlights();
    // The charging point is needed only for the electric vehicles
    public virtual Builder AddExhaustSystem() {  return this;  }
    // To retrieve the constructed product. 
    public abstract Car GetCar();
}
