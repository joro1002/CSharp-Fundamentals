using System;
using System.Collections.Generic;
using System.Text;


public class engine
{
    private int speed;
    private int power;

    public engine(int speed, int power)
    {
        this.speed = speed;
        this.power = power;
    }
   
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    
    public int Power
    {
        get { return power; }
        set { power = value; }
    }
}

