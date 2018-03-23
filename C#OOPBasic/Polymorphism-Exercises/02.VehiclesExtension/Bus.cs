using System;

public class Bus : Vehicles
{
    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        var fuelNeeded = distance * (this.FuelConsumptionPerKm + 1.4);

        if (fuelNeeded > this.FuelQuantity)
        {
            throw new ArgumentException($"{this.GetType().Name} needs refueling");
        }

        this.FuelQuantity -= fuelNeeded;
    }

    public void DriveEmpty(double distance)
    {
        base.Drive(distance);
    }
}

