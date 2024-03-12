using System;
using System.Collections.Generic;

namespace RealEstateManagementSystem
{
    public class Program
    {
        //Main method which gets user's choice and returns the choice as an integer value
        public static int Menu()
        {
            int option;      
            
            do
            {
                Console.WriteLine("Enter 1: To add a House\nEnter 2: To add an apartment\nEnter 3: To quit\nEnter your choice: ");
                string input = Console.ReadLine();
                //Validating user's choice
                if(!int.TryParse(input, out option) || (option < 1 || option > 3))
                {                    
                    Console.WriteLine("Please select valid option");
                }         
                else
                {
                    break;
                }
            }   
            while (true);

            return option;
        }

        public static void Main(string[] args)
        {
            //Creating lists of type House and Apartment class
            List<House> houses = new List<House>();
            List<Apartment> apartments = new List<Apartment>();
            int choice;

            do
            {
                //Storing user's choice in "choice" variable as an integer
                choice = Menu();

                //User chooses to add house
                if(choice == 1)
                {
                    int garage;
                    int type;
                    int condition;

                    do
                    {
                        //Prompting the user to enter all necessary data about the house 
                        Console.WriteLine("Please enter number of garage: ");
                        string garage_input = Console.ReadLine();
                        Console.WriteLine("Please enter type of house(1. Detached 2. Non-Detached): ");
                        string type_input = Console.ReadLine();
                        Console.WriteLine("Please enter condition of house(1. Sale 2. Rent): ");
                        string condition_input = Console.ReadLine();

                        //Validating all the details of house
                        if (!int.TryParse(garage_input, out garage))
                        {
                            Console.WriteLine("Please enter valid garage details");
                        }
                        else if(!int.TryParse(type_input, out type) || (type != 1 && type != 2))
                        {
                            Console.WriteLine("Please enter valid house details");
                        }
                        else if(!int.TryParse(condition_input, out condition) || (condition != 1 && condition != 2))
                        {
                            Console.WriteLine("Please enter valid condition details");
                        }
                        else
                        {
                            break;
                        }
                    } 
                    while (true);

                    //Create a House object
                    House house = new House();

                    //Initializing data fields from user input
                    house.Garage = garage;
                    house.Type = type == 1 ? true : false;
                    house.Condition = condition == 1 ? true : false;

                    //Add this object to the list “houses” 
                    houses.Add(house);
                }
                //User chooses to add apartment
                else if (choice == 2)
                {
                    int unit;
                    int floor;
                    int parking;
                    
                    do
                    {
                        //Prompting the user to enter all necessary data about the apartment 
                        Console.WriteLine("Please enter unit number: ");
                        string unit_input = Console.ReadLine();
                        Console.WriteLine("Please enter floor number: ");
                        string floor_input = Console.ReadLine();
                        Console.WriteLine("Please enter the number of parking: ");
                        string parking_input = Console.ReadLine();

                        //Validating all the details of apartment
                        if (!int.TryParse(unit_input, out unit))
                        {
                            Console.WriteLine("Please enter valid unit number");
                        }
                        else if (!int.TryParse(floor_input, out floor))
                        {
                            Console.WriteLine("Please enter valid floor number");
                        }
                        else if (!int.TryParse(parking_input, out parking))
                        {
                            Console.WriteLine("Please enter valid parking details");
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true);

                    //Create an Apartment object
                    Apartment apartment = new Apartment();

                    //Initializing data fields from user input
                    apartment.Unit = unit;
                    apartment.Floor = floor;
                    apartment.Parking = parking;

                    //Add this object to the list “apartments” 
                    apartments.Add(apartment);

                }
                else if(choice == 3)
                {
                    Console.WriteLine("Thank you!");
                }
                else
                {
                    break;
                }
            }
            //Repeatedly asking the user to enter details until choice is 3
            while (choice != 3);

            float total_house_commission = 0;
            float total_apartments_commission = 0;

            //Appending the total commission of the houses
            foreach(House house in houses)
            {
                total_house_commission += house.CalculateCommission();             
            }

            //Appending the total commission of the apartments
            foreach (Apartment apartment in apartments)
            {
                total_apartments_commission += apartment.CalculateCommission();
            }

            //Output
            Console.WriteLine($"Total commission for {houses.Count} houses would be {total_house_commission}%.");
            Console.WriteLine($"Total commission for {apartments.Count} apartments would be {total_apartments_commission}%.");

            Console.ReadLine();
        }
    }
}
