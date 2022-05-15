using System;

public interface ICircuitUpdate
{

    float CalculateEarnings();
    float Seats_Available(float seats_Available);
}
public class Account : ICircuitUpdate
{
    public float seats_Available;
    public float crowd_Size;
    public float ticket_Price;
    public string circuit_Name;
    public string circuit_Country;
    public string circuit_Type;

    public float Seats_Available(float seats_Available)
    {
        return crowd_Size + seats_Available;
    }

    public float CalculateEarnings()
    {

        return (crowd_Size - seats_Available) * ticket_Price;
    }
    public struct Driver
    {
        public string driver_Name;
        public string driver_Country;
        public string driver_Team;
        public int driver_Number;
        public float driver_Rating;

    }
    public Driver dr;

}

public class Program
{

    public static void Main()
    {
        int numDrv, k, fm;
        string ans;
        Console.WriteLine("This is Program08");
        Console.WriteLine("How Many Drivers do you want to create?");
        numDrv = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to enter the following information");
        Account[] Arr_Drv = new Account[numDrv];
        for (int i = 0; i < Arr_Drv.Length; i++)
        {
            Arr_Drv[i] = new Account();
            Console.WriteLine("Give Details of Driver No: " + (i + 1));

            Console.WriteLine("Driver Name");
            Arr_Drv[i].dr.driver_Name = Console.ReadLine();
            Console.WriteLine("Driver Country");
            Arr_Drv[i].dr.driver_Country = Console.ReadLine();
            Console.WriteLine("Driver Team");
            Arr_Drv[i].dr.driver_Team = Console.ReadLine();
            Console.WriteLine("Driver Number");
            Arr_Drv[i].dr.driver_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Driver Rating");
            Arr_Drv[i].dr.driver_Rating = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter circuit name");
            Arr_Drv[i].circuit_Name = Console.ReadLine();
            Console.WriteLine("Please enter circuit country");
            Arr_Drv[i].circuit_Country = Console.ReadLine();
            Console.WriteLine("Please enter circuit type");
            Arr_Drv[i].circuit_Type = Console.ReadLine();
            Console.WriteLine("Please enter crowdsize");
            Arr_Drv[i].crowd_Size = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter seats available");
            Arr_Drv[i].seats_Available = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter ticket price");
            Arr_Drv[i]. ticket_Price = float.Parse(Console.ReadLine());


        }
        Console.WriteLine("Do you want to calculate earnings for event? Press Y if yes, and N for No");
        ans = Console.ReadLine();
        if (ans == "Y" || ans == "y")
        {
            Console.WriteLine("Specify the account number of driver for whom you want starting with 1");
            k = Convert.ToInt32(Console.ReadLine());
            if (k > numDrv + 1 || k < 0)
            {
                Console.WriteLine("Driver not created");
            }
            Console.WriteLine("To adjust crowd size enter positive number to add seats and negative number to remove seats");
            fm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjusted Minutes for this customer " + Arr_Drv[k - 1].Seats_Available(fm));
            Console.WriteLine("Charges for this customer " + Arr_Drv[k - 1].CalculateEarnings());

            Console.ReadKey();

        }
        for (int i = 0; i < Arr_Drv.Length; i++)
        {
            Console.WriteLine("Driver Name " + Arr_Drv[i].dr.driver_Name);
            Console.WriteLine("Driver Country " + Arr_Drv[i].dr.driver_Country);
            Console.WriteLine("Driver Team " + Arr_Drv[i].dr.driver_Team);
            Console.WriteLine("Driver Number " + Arr_Drv[i].dr.driver_Number);
            Console.WriteLine("Driver Rating " + Arr_Drv[i].dr.driver_Rating);
            Console.WriteLine("Circuit Name " + Arr_Drv[i].circuit_Name);
            Console.WriteLine("Circuit Country " + Arr_Drv[i].circuit_Country);
            Console.WriteLine("Circuit Type " + Arr_Drv[i].circuit_Type);
            Console.WriteLine("Total Earnings " + Arr_Drv[i].CalculateEarnings());


        }



        Console.WriteLine("Thank you for running Program08");
        Console.WriteLine("I definitely enjoy using my own information on projects. Having done the project once with preset data makes doing it again all the easier. Still very much enjoying my time with C#.");
        Console.WriteLine("Press any key to exit");

        Console.ReadKey();


    }
}

