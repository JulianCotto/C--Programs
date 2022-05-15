using System;
using static System.Console;

namespace Program05
{
    class Program05
    {
        static void Main()
        {
            Airport R1 = new Airport();
            WriteLine(R1.Display());
            WriteLine("\nThank you for running Program05");
            WriteLine("If someday, I could take my coding knowledge into the aviation field, I would consider myself a success. Thanks for providing an assignment that lets us explore our own creativity within coding");
            ReadKey();
        }
    }
    class Airport
    {
        private string country;
        private string city;
        private string airportCode;
        private int numTerminals;

        public Airport()
        {
            country = "Germany";
            city = "Frankfurt";
            airportCode = "FRA";
            numTerminals = 2;
        }
        public Airport(string paramCountry, string paramCity, string paramAirportCode, int paramNumTerminals)
        {
            country = paramCountry;
            city = paramCity;
            airportCode = paramAirportCode;
            numTerminals = paramNumTerminals;
        }
        public string GetCountry()
        {
            return country;
        }
        public string GetCity()
        {
            return city;
        }
        public string GetAirportCode()
        {
            return airportCode;
        }
        public int GetNumTerminals()
        {
            return numTerminals;
        }
        public void SetCountry(string paramCountry)
        {
            country = paramCountry;
        }
        public void SetCity(string paramCity)
        {
            city = paramCity;
        }
        public void SetAirportCode(string paramAirportCode)
        {
            airportCode = paramAirportCode;
        }
        public void SetNumTerminals(int paramNumTerminals)
        {
            numTerminals = paramNumTerminals;
        }
        public string Display()
        {
            string s = "Airpot Country: " + country + "\nAirport City: " + city + "\nAirport Code: " + airportCode + "\nNumber of Terminals at Airport: " + numTerminals;
            return s;
        }
    }
}
