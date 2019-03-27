using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_CapitalCity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise:Country/Capital city
            Dictionary<string, string> countriesWithCapitalCities = new Dictionary<string, string>() {
                { "Croatia", "Zagreb"},
                { "Italy", "Rome"},
                { "Zimbabwe", "Harare"},
                { "Uruguay", "Montevideo"},
                { "Austria" , "Vienna"},
                { "Maldivies", "Male"},
                { "Portugal","Lisbon"},
                { "Spain","Madrid"},
                { "Ukraine","Kiev"},
                { "Qatar","Doha"},
                { "Poland","Warsaw"},
                { "Netherlands","Amsterdam"}
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose what would you like to do:");
                Console.WriteLine("1) Add country with capital city");
                Console.WriteLine("2) Search by Country");

                var userInput = int.Parse(Console.ReadLine());

                bool success = false;
                while (!success)
                {
                    if (userInput == 1)
                    {
                        Console.WriteLine("Enter conutry:");
                        var country = Console.ReadLine();
                        Console.WriteLine("Enter capital city:");
                        var capitalCity = Console.ReadLine();

                        if (!countriesWithCapitalCities.ContainsKey(country) && !countriesWithCapitalCities.ContainsValue(capitalCity))
                        {
                            countriesWithCapitalCities.Add(country, capitalCity);
                            Console.WriteLine("--List of Countries and their capital cities--");
                            foreach (var item in countriesWithCapitalCities)
                            {
                                Console.WriteLine($"{ item.Key} - {item.Value}");
                            }
                            success = true;
                        }
                        else
                        {
                            Console.WriteLine("The country and the capital already exist!");
                            Console.WriteLine("Please try again:");
                        }
                    }
                    if (userInput == 2)
                    {

                        Console.WriteLine("Enter country:");
                        string country = Console.ReadLine();

                        if (countriesWithCapitalCities.ContainsKey(country))
                        {
                            Console.WriteLine($"The capital city of {country} is {countriesWithCapitalCities[country]}");
                            success = true;
                        }
                        else
                        {
                            Console.WriteLine("The country you enter does not exists!");
                        }

                    }
                    else if (userInput != 1 && userInput != 2)
                    {
                        Console.WriteLine("The input you are enter is in wrong format!");
                    }
                }
                
                Console.ReadLine();
            }

        } 
    }
}
