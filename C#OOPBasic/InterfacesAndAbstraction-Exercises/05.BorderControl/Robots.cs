public class Robots : IIdentable
{
    private string model;
    private string id;

    public Robots(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

}

