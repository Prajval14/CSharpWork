using System;

namespace Question_1
{
    public class Residence
    {
        public float Price;
        public float SquareFeet;
        public int YearBuilt;
        public string Address;
        public float commissionAmount;

        public Residence()
        {
            Price = 0.00F;
            SquareFeet = 000.0F;
            YearBuilt = 0000;
            Address = "Default Address";
        }

        public Residence(float price, float squareFeet, int yearBuilt, string address)
        {
            Price = price;
            SquareFeet = squareFeet;
            YearBuilt = yearBuilt;
            Address = address;
        }

        public float CalculateCommission()
        {
            commissionAmount = 2.8F;
            return commissionAmount;
        }

        public void PrintResidence()
        {
            Console.WriteLine($"Price: ${Price}\nSquare Feet: {SquareFeet}ft\nYear Built: {YearBuilt}\nAddress: {Address}");
        }
    }
}
