using System;
using static System.Console;

namespace Program04
{
    class Program04
    {
        static void Main()
        {
            int numPaintings, year;
            string artist, genre, country;
            double price, commission, tax, duty, retailPrice;
            WriteLine("How many painintgs do you want to create");
            numPaintings = Convert.ToInt32(Console.ReadLine());
            Painting[] paintings = new Painting[numPaintings];
            for (int i = 0; i < paintings.Length; i++)
            {
                WriteLine("Painting " + (i + 1));
                WriteLine("Please Enter Artist");
                artist = ReadLine();
                WriteLine("Please Enter Genre");
                genre = ReadLine();
                WriteLine("Please Enter Country");
                country = ReadLine();
                WriteLine("Please Enter Year");
                year = Convert.ToInt32(Console.ReadLine());
                WriteLine("Please Enter Wholesale Price");
                price = Convert.ToDouble(Console.ReadLine());
                WriteLine();

                paintings[i] = new Painting(artist, genre, country, year, price);
            }
            for (int i = 0; i < paintings.Length; i++)
            {
                WriteLine("Painting " + (i + 1));
                WriteLine("What is the sellers commission?");
                commission = Convert.ToDouble(ReadLine());
                WriteLine("What is the sales tax");
                tax = Convert.ToDouble(ReadLine());
                WriteLine("What is the sales duty?");
                duty = Convert.ToDouble(ReadLine());
                retailPrice = paintings[i].GetPrice() + commission + tax + duty;
                WriteLine(retailPrice);
                
            }
            WriteLine("Thank you for running Program04");
            WriteLine("This was fun. I really enjoyed creating the different functions that would later be called on in the main function");
            ReadKey();
        }
    }
    class Painting
    {
        private string artist;
        private string genre;
        private string country;
        private int year;
        private double price;
        

        public Painting()
        {
            artist = "Van Gough";
            genre = "Classic";
            country = "Italy";
            year = 1716;
            price = 3000.00;
        }
        public Painting(string paramArtist, string paramGenre, string paramCountry, int paramYear, double paramPrice)
        {
            artist = paramArtist;
            genre = paramGenre;
            country = paramCountry;
            year = paramYear;
            price = paramPrice;
        }
        public string GetArtist()
        {
            return artist;
        }
        public string GetGenre()
        {
            return genre;
        }
        public string GetCountry()
        {
            return country;
        }
        public int GetYear()
        {
            return year;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetArtist(string paramArtist)
        {
            artist = paramArtist;
        }
        public void SetGenre(string paramGenre)
        {
            genre = paramGenre;
        }
        public void SetCountry(string paramCountry)
        {
            country = paramCountry;
        }
        public void SetYear(int paramYear)
        {
            year = paramYear;
        }
        public void SetPrice(double paramPrice)
        {
            price = paramPrice;
        }
    }
}



