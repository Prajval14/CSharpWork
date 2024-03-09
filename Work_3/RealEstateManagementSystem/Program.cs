using System;

namespace RealEstateManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Prompting the user to enter the requested details
            Console.WriteLine("Enter the street name: ");
            string street = Console.ReadLine();
            Console.WriteLine("Enter the municipality name: ");
            string municipality = Console.ReadLine();
            Console.WriteLine("Enter the region name: ");
            string region = Console.ReadLine();
            Console.WriteLine("Enter the postal code: ");
            string postal_code = Console.ReadLine();

            //Creating an instance of the address class 
            Address stringAddress = new Address(street, municipality, region, postal_code);

            //Displaying the address object's information using PrintAddress method
            stringAddress.PrintAddress();

            //Prompting the user to enter the requested details
            Console.WriteLine("Enter the price: ");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the square foot: ");
            float square_feet = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year built: ");
            int year_built = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the address: ");
            string address = Console.ReadLine();

            //Creating an instance of the residence class 
            Residence stringResidence = new Residence(price, square_feet, year_built, address);

            //Displaying the residence object's information using PrintResidence method
            stringResidence.PrintResidence();

            Console.ReadLine();
        }
    }
}
