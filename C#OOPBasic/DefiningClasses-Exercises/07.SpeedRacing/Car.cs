using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private double fuel;
    private double fuelFor1Km;
    private double distanceTraveled;

    public Car(string model, double fuel, double fuelFor1)
    {
        this.model = model;
        this.fuel = fuel;
        this.fuelFor1Km = fuelFor1;
        this.distanceTraveled = 0;
    }
   

    public string Model
    {
        get { return model; }
        set { model = value; }
    }
   
    public double Fuel
    {
        get { return fuel; }
        set { fuel = value; }
    }
    
    public double FuelFor1Km
    {
        get { return fuelFor1Km; }
        set { fuelFor1Km = value; }
    }
  
    public double DistanceTraveled
    {
        get { return distanceTraveled; }
        set { distanceTraveled = value; }
    }



    public void Drive(int amountOfKilometers)
    {
        if (amountOfKilometers <= this.fuel / this.fuelFor1Km)
        {
            this.distanceTraveled += amountOfKilometers;
            this.fuel -= this.fuelFor1Km * amountOfKilometers;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}

