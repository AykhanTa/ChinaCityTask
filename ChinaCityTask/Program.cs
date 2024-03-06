namespace ChinaCityTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result;
            int massiveLength;
            do
            {
                Console.WriteLine("Enter array length");
                result = Console.ReadLine();

            } while (!int.TryParse(result, out massiveLength));
            
            ChinaCity[] cities = new ChinaCity[massiveLength];

            for (int i = 0; i < cities.Length; i++)
            {
                string cityName;
                do
                {
                    Console.WriteLine("Enter city name:");
                    cityName = Console.ReadLine();

                } while (string.IsNullOrEmpty(cityName));

                int population;
                string strPopulation;
                do
                {
                    Console.WriteLine("Popualation daxil edin:");
                    strPopulation = Console.ReadLine();

                } while (!int.TryParse(strPopulation,out population));

                ChinaCity chinaCity = new ChinaCity();
                chinaCity.Name = cityName;
                chinaCity.Population = population;
                cities[i] = chinaCity;
            }

            int totalPopulation=0;
            foreach (var item in cities)
            {
                totalPopulation+=item.Population;
            }
            Console.WriteLine(totalPopulation/cities.Length);
        }
       
    }
}
