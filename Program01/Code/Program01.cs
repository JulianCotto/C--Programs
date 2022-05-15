using System;
public class HelloWorld2
{
	
	public static void Main(string[] args)
	{
		int incrementor = 5;
		int counter = 0;
		Console.WriteLine("This is a replacement program");
		Console.WriteLine("This is Program01.");
		Console.WriteLine("Please enter 5 days of the week");
		Console.WriteLine("Enter your first day");
		string dayone = Console.ReadLine();
		if (counter <= 5)
		{
			incrementor = incrementor - 1;
			counter = counter + 1;
		}
		Console.WriteLine("You have " + incrementor + " days left to enter");
		Console.WriteLine("Enter your second day");
		string daytwo = Console.ReadLine();
		if (counter <= 5)
		{
			incrementor = incrementor - 1;
			counter = counter + 1 ;
		}
		Console.WriteLine("You have " + incrementor + " days left to enter");
		Console.WriteLine("Enter your third day");
		string daythree = Console.ReadLine();
		if (counter <= 5)
		{
			incrementor = incrementor - 1;
			counter = counter + 1;
		}
		Console.WriteLine("You have " + incrementor + " days left to enter");
		Console.WriteLine("Enter your fourth day");
		string dayfour = Console.ReadLine();
		if (counter <= 5)
		{
			incrementor = incrementor - 1;
			counter = counter + 1;
		}
		Console.WriteLine("You have " + incrementor + " day left to enter");
		Console.WriteLine("Enter your fifth day");
		string dayfive = Console.ReadLine();
		if (counter <= 5)
		{
			counter = counter + 1;
		}
		Console.WriteLine("You entered the following " + counter + " days:");
		Console.WriteLine(dayone + " " + daytwo + " " + daythree + " " + dayfour + " and " + dayfive);
		Console.WriteLine("________________________________________________");
		
		Console.WriteLine("Thank you for running Program01");
		Console.WriteLine("Program01 always should've been an easy A. Thats why I decided to go back and resubmit it. Using everything I learned over the course, I was easily able to complete it and make it even better");
		{
			Console.Write("Press any key to proceed");
			Console.ReadKey(true);
		}
	}
}