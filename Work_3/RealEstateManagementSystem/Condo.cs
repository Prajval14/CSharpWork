using System;

namespace RealEstateManagementSystem
{
    class Condo : Residence
    {
        //Declaring the properties(attributes) with appropriate data types
        public int Unit;
        public int Floor;
        public int Parking;
        public float condoCommission;

        //A no-arg constructor that creates a default condo
        public Condo()
        {
            Unit = 1;
            Floor = 0;
            Parking = 1;
        }

        //A constructor that creates a condo with the specified unit, price and parking
        public Condo(int unit, int floor, int parking)
        {
            Unit = unit;
            Floor = floor;
            Parking = parking;
        }        

        //A method that overrides the commission amount
        public override float CalculateCommission()
        {
            condoCommission = 4.0F;
            return condoCommission;
        }

        //A method to print out all available information about the current object
        public void PrintCondo()
        {
            Console.WriteLine($"Unit: {Unit}\nFloor: {Floor}\nParking: {Parking}");
        }
    }
}
