public class Car : Vehicles
{
    public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {
        this.FuelConsumptionPerKm += 0.9;
    }
}
