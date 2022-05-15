using System.IO;
using System;

class Program
{
    static double smallest, largest, sum, avg;
    
    public static void findValues(double[] m)
    {
        smallest = m[0];
        largest = m[0];
        sum = m[0];
        for (int i = 1; i < 5; i++)
        {
            if (m[i] < smallest)
                smallest = m[i];
            if (m[i] > largest)
                largest = m[i];

            sum += m[i];
        }
        avg = sum / 5;
    }
    public static void rainValues(string[] m)
    {
        double temp;
        smallest = double.Parse(m[0]);
        largest = double.Parse(m[0]);
        sum = double.Parse(m[0]);
        for (int i = 1; i < 5; i++)
        {
            temp = double.Parse(m[i]);
            if (temp < smallest)
                smallest = temp;
            if (temp > largest)
                largest = temp;

            sum += temp;
        }
        avg = sum / 5;
    }
    public static void display()
    {
        Console.WriteLine("Sum     : " + sum);
        Console.WriteLine("Average : " + avg);
        Console.WriteLine("Smallest: " + smallest);
        Console.WriteLine("Largest : " + largest);
    }
    public static void Main()
    {
        double[] myDoubles = new double[5];
        string[] rainfallData = new string[5];

        Console.WriteLine("This is a Replacement Program");
        Console.WriteLine("This is a Submission for Program03");
        Console.WriteLine("This is Program03");
        //requesting 5 doubles
        Console.WriteLine("Enter 5 double values");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter value " + (i + 1) + ": ");
            myDoubles[i] = double.Parse(Console.ReadLine());
        }
        //finding smallest,largest,sum and average of 5 doubles
        findValues(myDoubles);
        //displaying result of doubles
        Console.WriteLine("\n______Double Array______");
        display();

        //requesting 5 day rainfall data
        
        Console.WriteLine("Prepare to enter rainfall data per day");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter Day of the Week to record Rainfall data for that day");
            string weekday = Console.ReadLine();
            Console.WriteLine((i + 1) + ". Enter rainfall amount for " + weekday + ": ");
            rainfallData[i] = Console.ReadLine();
            
        }
        //finding smallest,largest,sum and average of rainfall data
        rainValues(rainfallData);
        //displaying result of rainfall data
        Console.WriteLine("\n______Rainfall Data______");
        display();

        //jagged array demonstration

        Console.WriteLine("\n_______Jagged Array______");
        byte[][] jaggedArray = new byte[2][];
        jaggedArray[0] = new byte[] { 0x21, 0x20 };
        jaggedArray[1] = new byte[] { 0x22, 0x23, 0x24, 0x25 };

        //printing the value of jagged array
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row({0}): ", i);

            for (int k = 0; k < jaggedArray[i].Length; k++)
            {

                // Print the elements in the row
                Console.Write("{0} ", jaggedArray[i][k]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nThank you for running Program03");
        Console.WriteLine("\nThank you for running Replacement Program.");
        Console.WriteLine("\nThank you for running Replacement Program.");
        Console.WriteLine("When I first attempted this Program the Jagged- \nArray's really bended the limits of my mind.\nHindsight is 20/20 and this concept is-\nnot nearly as hard as I was making it.\nI am thankful for the oppurtunity to circle\nback and complete this work");
        Console.ReadKey();
    }

}