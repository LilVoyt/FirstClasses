using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public static class Practice
    {
        //Ex 1
        public static int MultiplyDiapasone(int start, int end)
        {
            int res = 1;
            for (int i = start; i <= end; i++)
            {
                res *= i;
            }
            return res;
        }

        //Ex 2
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        //Ex 3
        public static int[] SortArr(ref int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

    }

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

    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            int res = Practice.MultiplyDiapasone(2, 5);
            Console.WriteLine($"Result is: {res}");

            //Ex 2
            bool res2 = Practice.IsPrime(4);
            Console.WriteLine($"Result is: {res2}");

            //Ex 3
            int[] ints = new int[5] { 1, 4, 2, 5, 3 };
            Practice.SortArr(ref ints);
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Ex 4
            City city1 = new City();
            city1.Name = "Lviv";
            city1.Country = "Ukraine";
            city1.CityId = 777;
            city1.City_Districts = new string[] { "ditr1", "ditr2", "ditr3" };
            //city1.Print();
            Console.WriteLine(city1.Name);
            Console.WriteLine(City.CountryNumber);

        }
    }
}
