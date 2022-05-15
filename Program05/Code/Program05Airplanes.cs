using System;
using static System.Console;

namespace Program05
{
    class Program05
    {
        static void Main()
        {
            int airplaneNumber;
            int airplaneSpeed;
            int numAirplanes, speed;
            string airline, make, model, decision;
            WriteLine("This is Program05");
            WriteLine("How many airplanes would you like top create?");
            numAirplanes = Convert.ToInt32(ReadLine());
            Airplane[] airplanes = new Airplane[numAirplanes];
            for (int i = 0; i < numAirplanes; i++)
            {
                WriteLine("Airplane" + (i + 1));
                WriteLine("Please enter Airline");
                airline = ReadLine();
                WriteLine("Please Enter Make");
                make = ReadLine();
                WriteLine("Please Enter Model");
                model = ReadLine();
                WriteLine("Please Enter Speed");
                speed = Convert.ToInt32(ReadLine());
                WriteLine();


                airplanes[i] = new Airplane(airline, make, model, speed);
            }
            for (int i = 0; i < numAirplanes; i++)
            {
                WriteLine("Automobile" + (i + 1));
                WriteLine(airplanes[i]);
            }
            WriteLine("Do you want to increase or decrease an airplanes speed. I/D");
            decision = ReadLine();
            WriteLine("Please Select Airplane Number");
            airplaneNumber = Convert.ToInt32(ReadLine());
            WriteLine("Enter the amount of speed change for this airplane");
            airplaneSpeed = Convert.ToInt32(ReadLine());

            if (airplaneNumber >= 0 && airplaneNumber < numAirplanes)
            {
                if (decision == "I")
                    airplanes[airplaneNumber].IncreaseSpeed(airplaneSpeed);
                else
                    airplanes[airplaneNumber].DecreaseSpeed(airplaneSpeed);
                WriteLine(airplanes[airplaneNumber]);
            }
            else
                WriteLine("Invalid Entry");
            WriteLine("Thank you for running Program05");
            WriteLine("I find coding so much more fun when the forum is open ended. I was delighted to create coding around something I am interested in in real life!");
            ReadKey();

        }
    }
    class Airplane
    {
        private string airline;
        private string make;
        private string model;
        private int speed;


        public Airplane()
        {
            airline = "Delta";
            make = "Boeing";
            model = "777";
            speed = 700;


        }
        public Airplane(string paramAirline, string paramMake, string paramModel, int paramSpeed)
        {
            airline = paramAirline;
            make = paramMake;
            model = paramModel;
            speed = paramSpeed;
        }
        public string GetAirline()
        {
            return airline;
        }
        public string GetMake()
        {
            return make;
        }
        public string GetModel()
        {
            return model;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public void SetAirline(string paramAirline)
        {
            airline = paramAirline;
        }
        public void SetMake(string paramMake)
        {
            make = paramMake;
        }
        public void SetModel(string paramModel)
        {
            model = paramModel;
        }
        public void SetSpeed(int paramSpeed)
        {
            speed = paramSpeed;
        }
        public void IncreaseSpeed(int paramSpeed)
        {
            speed += paramSpeed;
        }
        public void DecreaseSpeed(int paramSpeed)
        {
            speed -= paramSpeed;
        }
        public void ShowSpeed(int paramSpeed)
        {
            WriteLine("This aircrafts speed is " + speed);
        }
        public override string ToString()
        {
            string s = "Airline: " + airline + "\n";
            s += "Make: " + make + "\n";
            s += "Model: " + model + "\n";
            s += "Speed: " + speed;
            return s;
        }
    }
}
