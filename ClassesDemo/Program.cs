using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cv firstCv = new Cv();

            Address address = new Address();


            firstCv.Pi.Address = address;
            Console.WriteLine("Country Name");


            Country country = new Country();
            country.Name = "ABC LAHORE";
            City city = new City(country);


            firstCv.Pi.Address.City = city;
          //  firstCv.Pi.Address.City.Country.Name = Console.ReadLine();
            Console.WriteLine($"Name : {firstCv.Pi.Address.City.Country.Name}");

            Console.ReadKey();
        }
    }
}
