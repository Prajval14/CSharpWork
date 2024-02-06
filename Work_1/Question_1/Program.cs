//Prepared By - Prajval Patel (C0911611)
//Date - Jan 21, 2024

using System;
using System.Collections.Generic;
using System.Linq;

namespace Question_1
{
    public class Program
    {
        //method to validate date input (based on online research)
        public static DateTime GetValidDateInput()
        {
            DateTime result;

            while (!DateTime.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid date.");
            }

            return result;
        }

        //method to validate float input (based on online research)
        public static float GetValidFloatInput()
        {
            float result;

            while (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid float number.");
            }

            return result;
        }

        public static void Main(string[] args)
        {
            //used lists to store classmates and classmates with highest GPA(can be more than one)
            List<ClassMate> classmatesList = new List<ClassMate>();
            List<string> highestGPAList = new List<string>();

            for (int i = 1; i < 6; i++)
            {
                ClassMate newClassmate = new ClassMate();

                Console.WriteLine($"--Classmate {i} Data--");

                Console.WriteLine("Please enter your first name: ");
                newClassmate.FirstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name: ");
                newClassmate.LastName = Console.ReadLine();
                Console.WriteLine("Please enter your birthdate (YYYY-MM-DD): ");
                newClassmate.DateOfBirth = GetValidDateInput();
                Console.WriteLine("Please enter your overall GPA: ");
                newClassmate.GPA = GetValidFloatInput();
                while (newClassmate.GPA > 4) //validating GPA range
                {
                    Console.WriteLine("Please enter valid GPA (0 to 4)");
                    newClassmate.GPA = GetValidFloatInput();
                }
                Console.WriteLine("--------------------------------------");
                //appeding classmatesList with newClassmate object
                classmatesList.Add(newClassmate);
            }

            //calculated highest using Max() and average with Average() functions from LINQ namespace
            float highestGPA = classmatesList.Max(x => x.GPA);

            float averageGPA = classmatesList.Average(x => x.GPA);

            Console.WriteLine("Classmates Record:");

            foreach (var classmate in classmatesList)
            {
                Console.WriteLine($"{classmate.FirstName} {classmate.LastName}, DOB: {classmate.DateOfBirth.ToShortDateString()}, GPA: {classmate.GPA}");
                //appending highestGPAList by comparing with highestGPA value
                if (classmate.GPA == highestGPA)
                {
                    highestGPAList.Add($"{classmate.FirstName} {classmate.LastName} with {classmate.GPA} GPA.");
                }
            }

            Console.WriteLine($"--------------------------------------\nFinal Report: \nThe average GPA of all the classmates are {averageGPA} and the classmates with highest GPA are:");
            
            foreach (var classmate in highestGPAList)
            {
                Console.WriteLine(classmate);
            }
            
            Console.WriteLine($"- {DateTime.Now}");
            
            Console.ReadLine();
        }
    }
}
