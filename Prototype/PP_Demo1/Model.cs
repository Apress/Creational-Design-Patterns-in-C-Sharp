class Model(string modelName = "Not defined", string color = " Not set")
{
    public string modelName = modelName;
    public string color = color;   
    public override string ToString()
    {
        return $"{modelName}, Color: {color}";
    }
}

//class Model
//{
//    public string modelName;
//    public string color;
//    public Model(string modelName = "Not defined", string color = " Not set")
//    {
//        this.modelName = modelName;
//        this.color = color;
//    }
//    public override string ToString()
//    {
//        return $"{modelName}, Color: {color}";
//    }
//}
