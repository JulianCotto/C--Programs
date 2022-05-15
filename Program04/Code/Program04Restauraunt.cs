using System;
using static System.Console;

namespace Program04
{
    class Program04
    {
        static void Main()
        {
            Restauraunt R1 = new Restauraunt();
            WriteLine(R1.Display());
            WriteLine("Thank you for running Program04");
            WriteLine("This was fun. I really enjoyed creating the different functions that would later be called on in the main function");
            ReadKey();
        }
    }
    class Restauraunt
    {
        private string city;
        private string chef;
        private string cuisineType;
        private double aaaDiamondRating;

        public Restauraunt()
        {
            city = "Chicago";
            chef = "Gordon Ramsey";
            cuisineType = "Hawaiian";
            aaaDiamondRating = 5;
        }
        public Restauraunt(string paramCity, string paramChef, string paramType, double paramRating)
        {
            city = paramCity;
            chef = paramChef;
            cuisineType = paramType;
            aaaDiamondRating = paramRating;
        }
        public string GetCity()
        {
            return city;
        }
        public string GetChef()
        {
            return chef;
        }
        public string GetType()
        {
            return cuisineType;
        }
        public double GetRating()
        {
            return aaaDiamondRating;
        }
        public void SetCity(string paramCity)
        {
            city = paramCity;
        }
        public void SetChef(string paramChef)
        {
            chef = paramChef;
        }
        public void SetType(string paramType)
        {
            cuisineType = paramType;
        }
        public void SetRating(double paramRating)
        {
            aaaDiamondRating = paramRating;
        }
        public string Display()
        {
           string s = city + " " + chef + " " + cuisineType + " " + aaaDiamondRating;
           return s;
        }
    }
}
