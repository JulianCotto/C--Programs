using System;
using static System.Console;

namespace Program04
{
    class Program04
    {
        static void Main()
        {
            int automobileNumber;
            int automobileSpeed;
            int numCars, speed;
            string make, color, model, decision;
            WriteLine("This is Program04");
            WriteLine("How many cars would you like top create?");
            numCars = Convert.ToInt32(ReadLine());
            Automobile[] automobiles = new Automobile[numCars];
            for (int i = 0; i < numCars; i++)
            {
                WriteLine("Automobile" + (i + 1));
                WriteLine("Please enter make");
                make = ReadLine();
                WriteLine("Please Enter Model");
                model = ReadLine();
                WriteLine("Please Enter Color");
                color = ReadLine();
                WriteLine("Please Enter Speed");
                speed = Convert.ToInt32(ReadLine());
                WriteLine();


                automobiles[i] = new Automobile(make, model, color, speed);
            }
            for (int i = 0; i < numCars; i++)
            {
                WriteLine("Automobile" + (i + 1));
                WriteLine(automobiles[i]);
            }
            WriteLine("Do you want to increase or decrease this cars speed. I/D");
            decision = ReadLine();
            WriteLine("Please Select Car Number");
            automobileNumber = Convert.ToInt32(ReadLine());
            WriteLine("Enter the new car speed");
            automobileSpeed = Convert.ToInt32(ReadLine());

            if (automobileNumber >= 0 && automobileNumber < numCars)
            {
                if (decision == "I")
                    automobiles[automobileNumber].IncreaseSpeed(automobileSpeed);
                else
                    automobiles[automobileNumber].DecreaseSpeed(automobileSpeed);
                WriteLine(automobiles[automobileNumber]);
            }
            else
                WriteLine("Invalid Entry");
            WriteLine("Thank you for running Program04");
            WriteLine("This was fun. I really enjoyed creating the different functions that would later be called on in the main function");
            ReadKey();

        }
    }
    class Automobile
    {
        private string make;
        private string model;
        private string color;
        private int speed;


        public Automobile()
        {
            speed = 100;
            make = "Ferrari";
            color = "Red";
            model = "F355";


        }
        public Automobile(string paramMake, string paramModel, string paramColor, int paramSpeed)
        {
            make = paramMake;
            model = paramModel;
            color = paramColor;
            speed = paramSpeed;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public string GetMake()
        {
            return make;
        }
        public string GetColor()
        {
            return color;
        }
        public string GetModel()
        {
            return model;
        }
        public void SetSpeed(int paramSpeed)
        {
            speed = paramSpeed;
        }
        public void SetMake(int paramMake)
        {
            speed = paramMake;
        }
        public void SetColor(int paramColor)
        {
            speed = paramColor;
        }
        public void SetModel(int paramModel)
        {
            speed = paramModel;
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
            WriteLine("This vehicle speed is " + speed);
        }
        public override string ToString()
        {
            string s = "Make: " + make + "\n";
            s += "Model: " + model + "\n";
            s += "Color: " + color + "\n";
            s += "Speed: " + speed;
            return s;
        }
    }
}