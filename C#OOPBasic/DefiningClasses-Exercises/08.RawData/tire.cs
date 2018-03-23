using System;
using System.Collections.Generic;
using System.Text;

public class tire
{
    private double pressure;
    private int age;

    public tire(double pressure, int age)
    {
        this.pressure = pressure;
        this.age = age;
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public double Pressure
    {
        get { return pressure; }
        set { pressure = value; }
    }

}

