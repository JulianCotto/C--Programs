// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;
    
namespace Program02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("This is Program02.");
            WriteLine("Please Prepare To Enter 3 Floats");
            float myFloat1 = 0.0f;
            float myFloat2 = 0.0f;
            float myFloat3 = 0.0f;

            WriteLine("Please Enter Your First Float");
            // use of Single.Parse() Method
            myFloat1 = Single.Parse(ReadLine());
            
            //printing the value
            WriteLine("Value = {0}", myFloat1 + "\n");

            WriteLine("Please Enter Your Second Float");
            myFloat2 = Single.Parse(ReadLine());

            //printing the value
            WriteLine("Value = {0}", myFloat2 + "\n");

            WriteLine("Please Enter Your Third Float");
            myFloat3 = Single.Parse(ReadLine());

            //printing the value
            WriteLine("Value = {0}\n", myFloat3 + "\n");

            float myNewFloat1 = (myFloat1 + myFloat2);
            WriteLine("Addition Result- " + myFloat1 + " + " + myFloat2 + " = " + myNewFloat1 + "\n");
            float myNewFloat2 = (myFloat3 * myFloat2);
            WriteLine("Multiplication Result- " + myFloat3 + " * " + myFloat2 + " = " + myNewFloat2 + "\n");
            float myNewFloat3 = (myFloat2 / myFloat1);
            WriteLine("Division Result- " + myFloat2 + " / " + myFloat1 + " = " + myNewFloat3 + "\n");
            

            double myDouble1 = myFloat1;
            WriteLine("Double 1 Result- " + myDouble1 + "\n");
            double myDouble2 = myFloat2;
            WriteLine("Double 2 Result- " + myDouble2 + "\n");
            double myDouble3 = myFloat3;
            WriteLine("Double 3 Result- " + myDouble3 + "\n");

            int myInt1 = (int)myFloat1;
            WriteLine("Int 1 Result- " + myInt1 + "\n");
            int myInt2 = (int)myFloat2;
            WriteLine("Int 1 Result- " + myInt2 + "\n");
            int myInt3 = (int)myFloat3;
            WriteLine("Int 1 Result- " + myInt3 + "\n");

            string myString1 = myFloat1.ToString();
            WriteLine("String 1 Result- " + myString1 + "\n");
            string myString2 = myFloat2.ToString();
            WriteLine("String 2 Result- " + myString2 + "\n");
            string myString3 = myFloat3.ToString();
            WriteLine("String 3 Result- " + myString3 + "\n");

            WriteLine("Please select from the following choices \t(A)\t(B)\t(C)\t(D)");
            string choiceA = ReadLine();
            switch (choiceA) 
            {
                case "A":
                    WriteLine("You Chose Choice A" + "\n");
                        break;
                case "B":
                    WriteLine("You Chose Choice B" + "\n");
                        break;
                case "C":
                    WriteLine("You Chose Choice C" + "\n");
                        break;
                case "D":
                    WriteLine("You Chose Choice D" + "\n");
                        break;
                default:
                    WriteLine("Invalid Entry" + "\n");
                        break;
            }

            if (myFloat1 < myFloat2)
                if (myFloat2 < myFloat3)
                    WriteLine("Your Floats in Ascending Order are " + myFloat1 + "\t" + myFloat2 + "\t" + myFloat3 + "\n");
                else
                    if (myFloat1 > myFloat3)
                    WriteLine("Your Floats in Ascending Order are " + myFloat3 + "\t" + myFloat1 + "\t" + myFloat2 + "\n");
                else
                    WriteLine("Your Floats in Ascending Order are " + myFloat1 + "\t" + myFloat3 + "\t" + myFloat2 + "\n");
            else
                if (myFloat1 < myFloat3)
                WriteLine("Your Floats in Ascending Order are " + myFloat2 + "\t" + myFloat1 + "\t" + myFloat3 + "\n");
                else
                    if (myFloat2 < myFloat3)
                        WriteLine("Your Floats in Ascending Order are " + myFloat2 + "\t" + myFloat3 + "\t" + myFloat1 + "\n");
                else
                    WriteLine("Your Floats in Ascending Order are " + myFloat2 + "\t" + myFloat3 + "\t" + myFloat1 + "\n");

            WriteLine("Thank you for running Program02." + "\n");
            WriteLine("\nI originally missed the deadline for this program as it was more difficult to me that Program01. After seeking online tutoring as well as outside resources I am happy to say I understand the concepts. Thank you for the clear cut coursework" + "\n");


            ReadKey();
        }
    }
}
