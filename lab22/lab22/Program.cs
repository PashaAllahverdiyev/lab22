using lab22;

internal class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle("Bmw","f30",15000,30);
        Car car = new Car("Bmw", "f30", 15000, 30,50);
        car.AddFuel();
    }
}
public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Millage { get; set;  }
    public double CurrentFuel { get; set; }
    public Vehicle(string brand,string model,int millage,int currentfuel)
    {
        Brand = brand;
        Model = model;
        Millage = millage;
        CurrentFuel = currentfuel;
    }
}