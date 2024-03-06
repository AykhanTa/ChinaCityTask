namespace ChinaCityTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.Name = "Nakhcivan";
            city.Population = 100000;
            Console.WriteLine(city.Name);
            Console.WriteLine(city.Population);
        }
    }
}