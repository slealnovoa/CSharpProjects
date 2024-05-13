using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoInfoModeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            var sortedByNameCountries = Country.GetCountries().OrderBy(c => c.Name);
            Console.Write("1.1 ");
            foreach (var country in sortedByNameCountries)
            {
                Console.Write(country.Name + " - ");
            }
            Console.WriteLine("\n");

            //1.2
            var sortedByResourceCountCountries = Country.GetCountries().OrderByDescending(c => c.Resources.Count);
            Console.Write("1.2 ");
            foreach (var country in sortedByResourceCountCountries)
            {
                Console.Write(country.Name + " - ");
            }
            Console.WriteLine("\n");

            //1.3
            var argentinaBorderCountries = Country.GetCountries().Where(c => c.Borders.Contains("Argentina"));
            Console.Write("1.3 ");
            foreach (var borderCountry in argentinaBorderCountries)
            {
                Console.Write(borderCountry.Name + " - ");
            }
            Console.WriteLine("\n");

            //1.4
            var populationOverTenMillionCountries = Country.GetCountries().Where(c => c.Population > 10000000);
            Console.Write("1.4 ");
            foreach (var country in populationOverTenMillionCountries)
            {
                Console.Write(country.Name + " - ");
            }
            Console.WriteLine("\n");

            //1.5
            var countryWithLargestPopulation = Country.GetCountries().OrderByDescending(c => c.Population).First();
            Console.Write("1.5 ");
            Console.Write(countryWithLargestPopulation.Name + " ");
            Console.WriteLine("\n");

            //1.6
            var distinctReligions = Country.GetCountries()
                .SelectMany(c => c.Religions)
                .Distinct()
                .OrderBy(r => r);
            Console.Write("1.6 ");
            foreach (var religion in distinctReligions)
            {
                Console.Write(religion + " - ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
