//DYLAN GRANDJEAN
//Assignment 7 - TripApp
//Program designed to calculate the miles per gallon and cost per mile
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call methods for the header and instructions
            Header();
            Description();

            //Instantiate class
            TripCalculation tripApp = new TripCalculation();

            //Get user input
            Console.Write("Destination: ");
            tripApp.Destination = Console.ReadLine();
            Console.Write("Enter distance (miles): ");
            tripApp.Distance = double.Parse(Console.ReadLine());
            Console.Write("Enter Cost of gas: ");
            tripApp.Price = double.Parse(Console.ReadLine());
            Console.Write("Enter Gallons of gas: ");
            tripApp.Gallons = double.Parse(Console.ReadLine());

            //Display formatted output
            Console.WriteLine(tripApp.ToString());
            Console.Read();


        }

        //Display the programmer's  and program's name, program's purpose
        public static void Header()
        {
            Console.WriteLine("\tTrip Calculator\n" +
                              "\tCalculate Miles perGallon and Cost per Mile\n" +
                              "\tDylan Grandjean\n\t" +
                              DateTime.Today.ToShortDateString());
        }

        //Display intrution to the end-user
        public static void Description()
        {
            Console.WriteLine("*******************************************************\n" +
                              "This program will determine Miles per Gallon\n" +
                              "and Cost per Mile of a trip\n\n" +
                              "You will be asked to enter destination, distance in miles,\n" +
                              "cost of gas, and number of gallons of gas used.\n\n" +
                              "*******************************************************");
        }
    }
}
