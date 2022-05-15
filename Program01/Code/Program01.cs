using System;
public class HelloWorld2
{
	
	public static void Main(string[] args)
	{
		int counter = 0;
		Console.WriteLine("This is Program01.");
		Console.WriteLine("Please enter 5 days of the week");
		Console.WriteLine("Enter your first day");
		string dayone = Console.ReadLine();
		if (counter <= 5)
		{
			counter = counter + 1;
		}
		Console.WriteLine("Enter your second day");
		string daytwo = Console.ReadLine();
		if (counter <= 5)
		{
			counter = counter + 1 ;
		}
		Console.WriteLine("Enter your third day");
		string daythree = Console.ReadLine();
		if (counter <= 5)
		{
			counter = counter + 1;
		}
		Console.WriteLine("Enter your fourth day");
		string dayfour = Console.ReadLine();
		if (counter <= 5)
		{
			counter = counter + 1;
		}
		Console.WriteLine("Enter your fifth day");
		string dayfive = Console.ReadLine();
		if (counter <= 5)
		{
			counter = counter + 1;
		}
		Console.WriteLine("You entered the following " + counter + " days:");
		Console.WriteLine(dayone + " " + daytwo + " " + daythree + " " + dayfour + "and" + dayfive);
		Console.WriteLine("________________________________________________");
		
		Console.WriteLine("Thank you for running Program01");
		Console.WriteLine("When I first began studying for Program01 I was overuncumbered with the new vocabulary. After following all instructions and dedicating myself to replicating all examples provided, I can gladly say that Program01 was no issue for me. Thank you for providing clear cut coursework.");
		{
			Console.Write("Press any key to proceed");
			Console.ReadKey(true);
		}
	}
}