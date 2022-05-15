using System;

public interface IAccountUpdate
{

    float CalculateCharge();
    float AdjustMinutes(float Free_Minutes);
}
public class Account : IAccountUpdate 
{
    public float Balance_Owed;
    public float Minutes_Used;
    public float Cost_Per_Minute;
    public string Customer_Name;
    public string Address;
    public string Credit_CN;
    
    public float AdjustMinutes (float Free_Minutes) 
    {
        return Minutes_Used + Free_Minutes;
    }

    public float CalculateCharge()
    {

        return (Balance_Owed + (Cost_Per_Minute * Minutes_Used));
    }
    public struct Phone
    {
        public string PhoneNo;
        public string Manufacturer;
        public string Model;
        public string Operating_System;
        public string Diagonal_Screen_Size;

    }
    public Phone ph;

}

public class Program
{

    public static void Main()
    {
        int numAcc, k, fm;
        string ans;
        Console.WriteLine("This is Program07");
        Console.WriteLine("How Many Accounts do you want to create?");
        numAcc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to enter the following information");
        Account[] Arr_Acc = new Account[numAcc];
        for (int i = 0; i < Arr_Acc.Length; i++)
        {
            Arr_Acc[i] = new Account();
            Console.WriteLine("Give Details of Account No: " + (i + 1));

            Console.WriteLine("PhoneNo");
            Arr_Acc[i].ph.PhoneNo = Console.ReadLine();
            Console.WriteLine("Manufacturer");
            Arr_Acc[i].ph.Manufacturer = Console.ReadLine();
            Console.WriteLine("Model");
            Arr_Acc[i].ph.Model = Console.ReadLine();
            Console.WriteLine("Operating System");
            Arr_Acc[i].ph.Operating_System = Console.ReadLine();
            Console.WriteLine("Diagonal Screen Size");
            Arr_Acc[i].ph.Diagonal_Screen_Size = Console.ReadLine();
            Console.WriteLine("Please enter customer name");
            Arr_Acc[i].Customer_Name = Console.ReadLine();
            Console.WriteLine("Please enter customer address");
            Arr_Acc[i].Address = Console.ReadLine();
            Console.WriteLine("Please enter customer Credit Card Number");
            Arr_Acc[i].Credit_CN = Console.ReadLine();
            Console.WriteLine("Balance Owed");
            Arr_Acc[i].Balance_Owed = float.Parse(Console.ReadLine());
            Console.WriteLine("Minutes Used by Customer");
            Arr_Acc[i].Minutes_Used = float.Parse(Console.ReadLine());
            Console.WriteLine("Cost Per Minute ");
            Arr_Acc[i].Cost_Per_Minute = float.Parse(Console.ReadLine());


        }
        Console.WriteLine("Do you want to calculate charges for customer? Press Y if yes, and N for No");
        ans = Console.ReadLine();
        if (ans == "Y" || ans == "y")
        {
            Console.WriteLine("Specify the account number of customer for whom you want starting with 1");
            k = Convert.ToInt32(Console.ReadLine());
            if (k > numAcc + 1 || k < 0)
            {
                Console.WriteLine("Customer account not created");
            }
            Console.WriteLine("To adjust customer minutes enter positive number to add minutes and negative number to remove minutes");
            fm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjusted Minutes for this customer " + Arr_Acc[k - 1].AdjustMinutes(fm));
            Console.WriteLine("Charges for this customer " + Arr_Acc[k - 1].CalculateCharge());

            Console.ReadKey();

        }
        for (int i = 0; i < Arr_Acc.Length; i++)
        {
            Console.WriteLine("Customer Name " + Arr_Acc[i].Customer_Name);
            Console.WriteLine("Phone Number " + Arr_Acc[i].ph.PhoneNo);
            Console.WriteLine("Phone Manufacturer " + Arr_Acc[i].ph.Manufacturer);
            Console.WriteLine("Phone Model " + Arr_Acc[i].ph.Model);
            Console.WriteLine("Phone OS " + Arr_Acc[i].ph.Operating_System);
            Console.WriteLine("Phone Diagonal Screen Size " + Arr_Acc[i].ph.Diagonal_Screen_Size);
            Console.WriteLine("Customer Address " + Arr_Acc[i].Address);
            Console.WriteLine("Customer Credit Card Number " + Arr_Acc[i].Credit_CN);
            Console.WriteLine("Customer Charges " + Arr_Acc[i].CalculateCharge());


        }



        Console.WriteLine("Thank you for running Program07");
        Console.WriteLine("I am starting to see how these assignments build on the assignment before it. I am still strugling my way through the assignment but I am getting there eventaully. That means I am learning!!");
        Console.WriteLine("Press any key to exit");

        Console.ReadKey();


    }
}
