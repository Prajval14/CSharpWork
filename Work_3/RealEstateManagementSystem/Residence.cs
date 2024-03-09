using System;

namespace RealEstateManagementSystem
{
    //Residence class created
    public class Residence
    {
        //Declaring the properties(attributes) with appropriate data types
        public float Price;
        public float SquareFeet;
        public int YearBuilt;
        public string Address;
        public float commissionAmount;

        //A no-arg constructor that creates a default Residence
        public Residence()
        {
            Price = 0.00F;
            SquareFeet = 000.0F;
            YearBuilt = 0000;
            Address = "Default Address";
        }

        //A constructor that creates a Residence with the specified price, squareFeet, yearBuilt and address
        public Residence(float price, float squareFeet, int yearBuilt, string address)
        {
            Price = price;
            SquareFeet = squareFeet;
            YearBuilt = yearBuilt;
            Address = address;
        }

        //A method that returns the commission amount
        public float CalculateCommission()
        {
            commissionAmount = 2.8F;
            return commissionAmount;
        }

        //A method to print out all available information about the current object
        public void PrintResidence()
        {
            Console.WriteLine($"Price: ${Price}\nSquare Feet: {SquareFeet}ft\nYear Built: {YearBuilt}\nAddress: {Address}");
        }
    }
}
