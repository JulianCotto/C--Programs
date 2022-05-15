using System;
using static System.Console;

namespace Program05
{
    class Program05
    {
        static void Main()
        {
            int numHelicopters, rounds, missionTime, targets, cannons, numRounds;
            string military, make, model, serviceMission;
            WriteLine("How many helicopters do you want to create");
            numHelicopters = Convert.ToInt32(Console.ReadLine());
            Helicopter[] helicopters = new Helicopter[numHelicopters];
            for (int i = 0; i < helicopters.Length; i++)
            {
                WriteLine("Helicopter " + (i + 1));
                WriteLine("Please Enter Country of Miltary");
                military = ReadLine();
                WriteLine("Please Enter Make");
                make = ReadLine();
                WriteLine("Please Enter Model");
                model = ReadLine();
                WriteLine("Please Enter Service Mission");
                serviceMission = ReadLine();
                WriteLine("Please Enter Number of Rounds"); //Number of bullets the main cannon holds
                rounds = Convert.ToInt32(Console.ReadLine());
                WriteLine();

                helicopters[i] = new Helicopter(military, make, model, serviceMission, rounds);
            }
            for (int i = 0; i < helicopters.Length; i++)
            {
                WriteLine("Helicopter " + (i + 1));
                WriteLine("How long is the mission projected to be in hours?");
                missionTime = Convert.ToInt32(ReadLine());
                WriteLine("How many projected targets are there?"); 
                targets = Convert.ToInt32(ReadLine());
                WriteLine("How many crew chief guns are available?"); //The amount of pivoting cannons opertaed by passengers from the passenger bay of the helicopter
                cannons = Convert.ToInt32(ReadLine());
                numRounds = helicopters[i].GetRounds() + (missionTime * 500) + (targets * 500) + ((cannons * 500)/2);
                WriteLine("The number of rounds needed for this mission is " + numRounds);

            }
            WriteLine("Thank you for running Program05");
            WriteLine("I'm really starting to get into a groove with C#. My wife just gave birth to our first child so progress has been slow going. Having said that I am pleased to have learned what I have so far");
            ReadKey();
        }
    }
    class Helicopter
    {
        private string military;
        private string make;
        private string model;
        private string serviceMission;
        private int rounds;


        public Helicopter()
        {
            military = "United States";
            make = "Sikorsky";
            model = "UH-60 Blackhawk";
            serviceMission = "DAP";
            rounds = 3000;
        }
        public Helicopter(string paramMilitary, string paramMake, string paramModel, string paramMission, int paramRounds)
        {
            military = paramMilitary;
            make = paramMake;
            model = paramModel;
            serviceMission = paramMission;
            rounds = paramRounds;
        }
        public string GetMiltary()
        {
            return military;
        }
        public string GetMake()
        {
            return make;
        }
        public string GetModel()
        {
            return model;
        }
        public string GetMission()
        {
            return serviceMission;
        }
        public int GetRounds()
        {
            return rounds;
        }
        public void SetMilitary(string paramMilitary)
        {
            military = paramMilitary;
        }
        public void SetMake(string paramMake)
        {
            make = paramMake;
        }
        public void SetModel(string paramModel)
        {
            model = paramModel;
        }
        public void SetYear(string paramMission)
        {
            serviceMission = paramMission;
        }
        public void SetPrice(int paramRounds)
        {
            rounds = paramRounds;
        }
    }
}



