public class Citizens: IIdentable
{
    private string name;
    private int age;
    private string id;

    public Citizens(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
}

