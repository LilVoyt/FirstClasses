using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public static int CountryNumber { get; private set; } //Створив випадково, але вирішив залишити) при кожному створенні країни тут здійснюється інкремент
        public int? CityId { get; set; }
        public string[] City_Districts { get; set; }

        public City()
        {
            Name = string.Empty;
            Country = string.Empty;
            CityId = null;
            City_Districts = null;

            CountryNumber++;
        }

        public City(string Country, int? CityId) : this()
        {
            this.Country = Country;
            this.CityId = CityId;
        }

        public City(string Name, string Country, int? CityId, string[] City_Districts) : this(Country, CityId)
        {
            this.Name = Name;
            this.City_Districts = City_Districts.ToArray(); //тут ми глубоко компіюємо масив, тобто створюємо ще один такий ж
        }

        public void Print()
        {
            Console.WriteLine($"Name is: {Name}");
            Console.WriteLine($"Country is: {Country}");
            Console.WriteLine($"CityId is: {CityId}");
            if (City_Districts != null)
            {
                Console.WriteLine($"City_Districts is: ");
                foreach (string i in City_Districts)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Here is no districts! ");
            }
        }
    }
}
