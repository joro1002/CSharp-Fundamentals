using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pomekons;

    public Trainer(string name)
    {
        this.name = name;
        badges = 0;
        this.pomekons = new List<Pokemon>();
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Badges
    {
        get { return badges; }
        set { badges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return pomekons; }
        set { pomekons = value; }
    }

}

