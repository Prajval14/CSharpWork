using System;

namespace RealEstateManagementSystem
{
    //Address class created
    public class Address
    {
        //Declaring the properties(attributes) with access specifier as private
        private string Street;
        private string Municipality;
        private string Region;
        private string PostalCode;

        //A no-arg constructor that creates a default Address
        public Address()
        {
            Street = "Default Street";
            Municipality = "Default Municipality";
            Region = "Default Region";
            PostalCode = "000000";
        }

        //A constructor that creates an address with the specified street, municipality, region, and postalCode
        public Address(string street, string municipality, string region, string postalCode)
        {
            Street = street;
            Municipality = municipality;
            Region = region;
            PostalCode = postalCode;
        }

        //A method to print out all available information about the current object
        public void PrintAddress()
        {
            Console.WriteLine($"Street: {Street}\nCity: {Municipality}\nState: {Region}\nZip Code: {PostalCode}");
        }
    }
}
