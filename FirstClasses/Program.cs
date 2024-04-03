using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
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
