using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private Car car;
    private Company company;
    private List<Pokemon> pokemon;
    private List<Family> parents;
    private List<Family> children;

    public Person(string name)
    {
        this.name = name;
        this.pokemon = new List<Pokemon>();
        this.parents = new List<Family>();
        this.children = new List<Family>();
        
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }

    public Company Company
    {
        get { return company; }
        set { company = value; }
    }

    public List<Pokemon> Pokemon
    {
        get { return pokemon; }
        set { pokemon = value; }
    }

    public List<Family> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Family> Children
    {
        get { return children; }
        set { children = value; }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine(this.name);

        builder.AppendLine("Company:");
        if (company != null)
        {
            builder.AppendLine(company.ToString());
        }

        builder.AppendLine("Car:");
        if (car != null)
        {
            builder.AppendLine(car.ToString());
        }

        builder.AppendLine("Pokemon:");
        this.pokemon.ForEach(p => builder.AppendLine(p.ToString()));

        builder.AppendLine("Parents:");
        this.parents.ForEach(p => builder.AppendLine(p.ToString()));

        builder.AppendLine("Children:");
        this.children.ForEach(ch => builder.AppendLine(ch.ToString()));

        return builder.ToString();
    }
}

