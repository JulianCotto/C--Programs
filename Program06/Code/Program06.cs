using System;

class Program
{
    int lowPSISetting;
    const int highPSISetting = 300;
    int desiredPSI;
    public void ChangeAirPressure()
    {
        Console.WriteLine("lowPSISetting: " + lowPSISetting);
        Console.WriteLine("highPSISetting: " + highPSISetting);
        Console.Write("Enter the desiredPSI: ");
        desiredPSI = int.Parse(Console.ReadLine());
        if (desiredPSI > lowPSISetting && desiredPSI < highPSISetting)
        {
            Console.WriteLine("desiredPSI is in range");
        }
        else
        {
            Console.WriteLine("desiredPSI is not in range");
        }
        Console.Write("Do you want to change the lowPSISetting? : ");
        string choice = Console.ReadLine();
        if (choice == "Y" || choice == "y")
        {
            Console.Write("Enter lowPSISetting : ");
            int newlowPSISetting = int.Parse(Console.ReadLine());
            if (desiredPSI > newlowPSISetting && desiredPSI < highPSISetting)
            {
                Console.WriteLine("desiredPSI is in range");
                lowPSISetting = newlowPSISetting;
            }
            else
            {
                Console.WriteLine("desiredPSI is not in range");
            }
            Console.WriteLine("Low PSI Setting: " + lowPSISetting + "\nHigh PSI Setting: " + highPSISetting);
            Console.ReadKey();
        }

    }
    public static void Main(string[] args)
    {
        Console.WriteLine("This is program06");
        Program obj = new Program();
        obj.ChangeAirPressure();
        Alarm obj1 = new Alarm();
        obj1.SoundAlarm();
        int result = obj1.GetAlarmCount();
        Console.WriteLine("number of times " + result);
        string choice;
        do
        {
            Console.WriteLine("Do you want to sound the alarm? Y/N");
            choice = Console.ReadLine();
            if (choice == "Y" || choice == "y")
            {
                obj1.SoundAlarm();
                Console.WriteLine(obj1.GetAlarmCount());
            }
        }
        while (choice != "n" && choice != "N");
        Console.WriteLine("Thank you for running Program06");
        Console.WriteLine("This program seemed a little bit more farfetched to me but I was able to knock it out and hit all of the requirements. As far as the alarm display I think it is doing what I am being asked for it to do. Thank you for the clear cut coursework.");
        Console.ReadKey();
    }
}
    class Alarm
    {
        //member to record alaram sounded
        int alarmCount = 0;

        //Methods
        public void SoundAlarm()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("The alarm is sounded");
            alarmCount++;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("The alarm is sounded");
            alarmCount++;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("The alarm is sounded");
            alarmCount++;
        }

        public int GetAlarmCount()
        {
            return alarmCount;
        }
    }


