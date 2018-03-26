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
    class TripCalculation
    {
        //Instantiate private variables
        private string destination;

        private double distance;
        private double price;
        private double gallons;
        
        private double mpg;
        private double costPerMile;

        //Declare variables through method properties
        public string Destination { set { destination = value; } }
        public double Distance { set { distance = value; } }
        public double Price { set { price = value; } }
        public double Gallons { set { gallons = value; } }

        //Calculate miles per gallon and cost per mile
        public void CalculateResults()
        {
            mpg = distance / gallons;
            costPerMile = price / distance;
        }

        //Format whole output ToString()
        public override string ToString()
        {
            CalculateResults();

            return "\n*******************************************************" +
                   "\nDestination: " + destination +
                   "\nTotal Miles: " + distance.ToString("n0") +
                   "\nFuel Consumed: " + gallons.ToString("n1") +
                   "\nCost: " + price.ToString("c") +
                   "\nMPG: " + mpg.ToString("n1") +
                   "\nCost per mile: " + costPerMile.ToString("c");
        }
    }
}
//DYLAN GRANDJEAN
//Assignment 7 - TripApp
//Program designed to calculate the miles per gallon and cost per mile
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7Trip_DylanGrandjean
{
    class TripCalculation
    {
        //Instantiate private variables
        private string destination;

        private double distance;
        private double price;
        private double gallons;
        
        private double mpg;
        private double costPerMile;

        //Declare variables through method properties
        public string Destination { set { destination = value; } }
        public double Distance { set { distance = value; } }
        public double Price { set { price = value; } }
        public double Gallons { set { gallons = value; } }

        //Calculate miles per gallon and cost per mile
        public void CalculateResults()
        {
            mpg = distance / gallons;
            costPerMile = price / distance;
        }

        //Format whole output ToString()
        public override string ToString()
        {
            CalculateResults();

            return "\n*******************************************************" +
                   "\nDestination: " + destination +
                   "\nTotal Miles: " + distance.ToString("n0") +
                   "\nFuel Consumed: " + gallons.ToString("n1") +
                   "\nCost: " + price.ToString("c") +
                   "\nMPG: " + mpg.ToString("n1") +
                   "\nCost per mile: " + costPerMile.ToString("c");
        }
    }
}
