namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.make = "Toyota";
            carOne.model = "Corolla";
            carOne.year = 2025;
            
            Console.WriteLine($"This is a {carOne.make} {carOne.model}, made in the year {carOne.year}.");
        }
    }
}
