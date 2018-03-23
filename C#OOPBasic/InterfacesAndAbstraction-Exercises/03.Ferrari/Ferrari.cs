public class Ferrari : ICar
{

    public Ferrari(string driverName)
    {
        this.Driver = driverName;
        this.Model = "488-Spider";
    }
    public string Model { get; set; }
    public string Driver { get; set; }

   public string UseBrakes()
   {
       return "Brakes!";
   }

    public string GazPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.UseBrakes()}/{this.GazPedal()}/{this.Driver}";
    }
}

