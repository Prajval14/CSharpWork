using System;

namespace Question_1
{
    public class Address
    {
        private string Street;
        private string Municipality;
        private string Region;
        private string PostalCode;

        public Address()
        {
            Street = "Default Street";
            Municipality = "Default Municipality";
            Region = "Default Region";
            PostalCode = "000000";
        }

        public Address(string street, string municipality, string region, string postalCode)
        {
            Street = street;
            Municipality = municipality;
            Region = region;
            PostalCode = postalCode;
        }

        public void PrintAddress()
        {
            Console.WriteLine($"Street: {Street}\nCity: {Municipality}\nState: {Region}\nZip Code: {PostalCode}");
        }
    }
}