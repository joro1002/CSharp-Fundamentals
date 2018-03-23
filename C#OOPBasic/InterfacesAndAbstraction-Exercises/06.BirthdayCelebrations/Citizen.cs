public class Citizen : IPerson, IBirthday, IIdentifiable
{
    public Citizen(string name, int age, string id, string birthDay)
    {
        this.Name = name;
        this.Age = age;
        this.ID = id;
        this.BirthDay = birthDay;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string BirthDay { get; set; }
    public string ID { get; set; }
}

