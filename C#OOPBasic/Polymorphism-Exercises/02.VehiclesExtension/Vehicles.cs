using System;

public class Vehicles
{
    private double fuelQuantity;
    private double fuelConsumptionPerKm;
    private double tankCapacity;

    protected Vehicles(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (value > this.TankCapacity)
            {
                this.fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = value;
            }
            this.fuelQuantity = value;
        }
    }

    public virtual double FuelConsumptionPerKm
    {
        get { return this.fuelConsumptionPerKm; }
        set { this.fuelConsumptionPerKm = value; }
    }

    public double TankCapacity
    {
        get { return tankCapacity; }
        set { tankCapacity = value; }
    }

    public virtual void Drive(double distance)
    {
        var fuelNeeded = distance * (this.FuelConsumptionPerKm);

        if (fuelNeeded > this.FuelQuantity)
        {
            throw new ArgumentException($"{this.GetType().Name} needs refueling");
        }

        this.FuelQuantity -= fuelNeeded;
    }

    public virtual void Refuel(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if (this.FuelQuantity + amount > this.tankCapacity)
        {
            throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
        }
        else
        {
            this.FuelQuantity += amount;
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}

