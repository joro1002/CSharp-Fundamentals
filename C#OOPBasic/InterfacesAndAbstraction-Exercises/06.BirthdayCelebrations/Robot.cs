public class Robot : IIdentifiable
{
    public Robot(string model, string id)
    {
        this.Model = model;
        this.ID = id;
    }
    public string Model { get;  set; }

    public string ID { get; set; }
}

