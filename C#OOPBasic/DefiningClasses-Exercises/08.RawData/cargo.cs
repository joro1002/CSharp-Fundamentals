using System;
using System.Collections.Generic;
using System.Text;

public class cargo
{
    private int weight;
    private string type;

    public cargo(int weight, string type)
    {
        this.type = type;
        this.weight = weight;
    }
    
    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }



}

