using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private engine engine;
    private cargo cargo;
    private tire[] tires;

    public Car(string model, engine engine, cargo cargo, tire[] tires)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }
    
    public cargo Cargo
    {
        get { return cargo; }
        set { cargo = value; }
    }

    public engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public tire[] Tires
    {
        get { return tires; }
        set { tires = value; }
    }
}

