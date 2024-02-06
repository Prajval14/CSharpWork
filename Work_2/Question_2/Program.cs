using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DentalEquipmentCompany dentalEquipmentCompany = new DentalEquipmentCompany();
            dentalEquipmentCompany.EmployeeSalary = 1000;
            dentalEquipmentCompany.SalesCommissionPercentage = 10;
            dentalEquipmentCompany.MonthSale = new double[12];
            dentalEquipmentCompany.TotalEarnings = 0;
            string[] monthsList = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int i = 0;

            Console.WriteLine("Dental Equipment Company\n------------------------------------------");

            Console.WriteLine("Please enter your name: ");
            dentalEquipmentCompany.EmployeeName = Console.ReadLine();

            while(i <  monthsList.Length)
            {
                Console.WriteLine($"Enter your gross sales amount for the month of {monthsList[i]} or enter '-1' to exit.");
                dentalEquipmentCompany.MonthSale[i] = Double.Parse(Console.ReadLine());

                if (dentalEquipmentCompany.MonthSale[i] == -1)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                dentalEquipmentCompany.MonthEarnings = dentalEquipmentCompany.EmployeeSalary + (dentalEquipmentCompany.MonthSale[i] * 10 / 100);

                Console.WriteLine($"Total earnings for {monthsList[i]}: ${dentalEquipmentCompany.MonthEarnings}.");

                dentalEquipmentCompany.TotalEarnings = dentalEquipmentCompany.TotalEarnings + dentalEquipmentCompany.MonthEarnings;

                i++;
            }

            Console.ReadLine();
        }
    }
}
