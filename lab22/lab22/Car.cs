namespace lab22
{
    public class Car:Vehicle 

    {
        public int FuelCapacity;

        public Car(string brand, string model, int millage, int currentfuel,int fuelcapacity) : base(brand, model, millage, currentfuel)
        {
            FuelCapacity = fuelcapacity;
        }

        public void AddFuel()
        {
            
            Console.WriteLine("Brand: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Model: ");
            string model = Console.ReadLine();
            Console.WriteLine();
            l1:
            Console.WriteLine("Bakda olan benzin");
            int currentfuel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Benzin elave edin");
            int fuel =Convert.ToInt32(Console.ReadLine());
            if (fuel + currentfuel > FuelCapacity)
            {
                Console.WriteLine("Limiti kecdi");
                goto l1;
            }
            else
            {
                Console.WriteLine("Benzin elave edildi");
            }
        }
    }
}
