using System;

namespace RealEstateManagementSystem
{
    //Creating a class named "Apartment" which is a subclass of Residence
    class Apartment : Residence
    {
        //Declaring the properties(attributes) with appropriate data types
        public int Unit;
        public int Floor;
        public int Parking;
        public float condoCommission;

        //A no-arg constructor that creates a default apt
        public Apartment()
        {
            Unit = 1;
            Floor = 0;
            Parking = 1;
        }

        //A constructor that creates a apt with the specified unit, price and parking
        public Apartment(int unit, int floor, int parking)
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
        public void PrintApartment()
        {
            Console.WriteLine($"Unit: {Unit}\nFloor: {Floor}\nParking: {Parking}");
        }
    }
}
