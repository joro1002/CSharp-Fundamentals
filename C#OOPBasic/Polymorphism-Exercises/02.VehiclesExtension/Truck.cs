using System;

public class Truck : Vehicles
{
    public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity,
        fuelConsumptionPerKm, tankCapacity)
    {
        this.FuelConsumptionPerKm += 1.6;
    }

    public override void Refuel(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if (this.FuelQuantity + amount * 0.95 > this.TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
        }

        this.FuelQuantity += amount * 0.95;
    }
}

