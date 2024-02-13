using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    public class C0911611_Question2
    {
        public static void Main(string[] args)
        {
            //creating instance of class
            DentalEquipmentCompany dentalEquipmentCompany = new DentalEquipmentCompany();

            //declaring values
            dentalEquipmentCompany.EmployeeSalary = 1000;
            dentalEquipmentCompany.SalesCommissionPercentage = 10;
            dentalEquipmentCompany.MonthSale = new double[12];
            dentalEquipmentCompany.TotalEarnings = 0;
            string[] monthsList = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int i = 0;
            bool exitRequest = false;

            Console.WriteLine("Dental Equipment Company\n------------------------------------------");

            //taking user's name
            Console.WriteLine("Please enter your name: ");
            dentalEquipmentCompany.EmployeeName = Console.ReadLine();

            //using while loop for 12 months data
            while (i < monthsList.Length)
            {
                //asking user for month's sale amount
                Console.WriteLine($"Enter your gross sales amount for the month of {monthsList[i]} or enter '-1' to exit.");

                //validating user input
                while (true)
                {
                    string input = Console.ReadLine();
                    bool isValidInput = double.TryParse(input, out dentalEquipmentCompany.MonthSale[i]);

                    if (isValidInput)
                    {
                        if (dentalEquipmentCompany.MonthSale[i] < -1)
                        {
                            Console.WriteLine("Amount cannot be negative. Please enter a non-negative amount.");
                        }
                        else if (dentalEquipmentCompany.MonthSale[i] == -1)
                        {
                            exitRequest = true;
                            break;
                        }
                        else
                        {
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid double amount.");
                    }
                }

                if (exitRequest)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    //calculating month's total income
                    dentalEquipmentCompany.MonthEarnings = dentalEquipmentCompany.EmployeeSalary + (dentalEquipmentCompany.MonthSale[i] * 10 / 100);

                    Console.WriteLine($"Total earnings for {monthsList[i]}: ${dentalEquipmentCompany.MonthEarnings}.");

                    //appending total year's income
                    dentalEquipmentCompany.TotalEarnings = dentalEquipmentCompany.TotalEarnings + dentalEquipmentCompany.MonthEarnings;
                }

                i++;
            }

            //Output
            Console.WriteLine($"------------------------------------------\nThank you for using our service {dentalEquipmentCompany.EmployeeName}. Your total earnings for the financial year is ${dentalEquipmentCompany.TotalEarnings}.");

            Console.ReadLine();
        }
    }
}
