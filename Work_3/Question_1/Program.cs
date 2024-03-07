using System;

namespace Question_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the street name: ");
            string street = Console.ReadLine();
            Console.WriteLine("Enter the municipality name: ");
            string municipality = Console.ReadLine();
            Console.WriteLine("Enter the region name: ");
            string region = Console.ReadLine();
            Console.WriteLine("Enter the postal code: ");
            string postal_code = Console.ReadLine();
            
            Address stringAddress = new Address(street, municipality, region, postal_code);

            stringAddress.PrintAddress();

            Console.WriteLine("Enter the price: ");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the square foot: ");
            float square_feet = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year built: ");
            int year_built = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the address: ");
            string address = Console.ReadLine();

            Residence stringResidence = new Residence(price, square_feet, year_built, address);

            stringResidence.PrintResidence();

            Console.ReadLine();
        }
    }
}
