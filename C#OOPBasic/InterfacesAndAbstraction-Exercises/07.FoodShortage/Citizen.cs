﻿public class Citizen : IBuy
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
        this.Food = 0;
    }

    public string Name { get; set; }
    public int Food { get; set; }
    public int Age { get;  set; }
    public string Id { get; private set; }
    public string Birthdate { get; private set; }



    public void BuyFood()
    {
        this.Food += 10;
    }
}